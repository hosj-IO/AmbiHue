﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using AmbiHue.Properties;
using SharpHue;

namespace AmbiHue
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public LightCollection LightCollection { get; set; }
        private BackgroundWorker _backgroundWorker;
        //Has to volatile to be accessible from an other thread
        private volatile bool _isAmbiRunning;

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            var whitelistedToolStripMenuItems = new List<ToolStripMenuItem>
            {
                //TODO maybe blacklist instead
                exitToolStripMenuItem,
                pairToolStripMenuItem,
                aboutToolStripMenuItem,
                helpToolStripMenuItem
            };
            ToggleControls(false, whitelistedToolStripMenuItems);
            buttonAmbiStop.Enabled = false;
            CheckForConfiguration();

            //Set Monitor info;
            var screens = GetMonitorInformation();
            var screenNamesList = screens.Select(screen => screen.DeviceName).ToList();
            comboBoxMonitors.DataSource = screenNamesList;
        }

        private IEnumerable<Screen> GetMonitorInformation()
        {
            return Screen.AllScreens.ToList();
        }

        //TODO rewrite this
        private void ToggleControls(bool isEnabled)
        {
            if (menuStripMain != null)
                foreach (ToolStripMenuItem item in menuStripMain.Items)
                {
                    if (item.HasDropDownItems)
                    {
                        foreach (var dropDownItem in item.DropDownItems)
                        {
                            var menuItem = dropDownItem as ToolStripMenuItem;
                            if (menuItem != null)
                                menuItem.Enabled = isEnabled;
                        }
                    }
                }

            buttonOn.Enabled = isEnabled;
            buttonOff.Enabled = isEnabled;
            buttonAmbiStart.Enabled = isEnabled;
        }
        private void ToggleControls(bool isEnabled, List<ToolStripMenuItem> whitelistedToolStripMenuItems)
        {
            if (menuStripMain != null)
                foreach (ToolStripMenuItem item in menuStripMain.Items)
                {
                    if (item.HasDropDownItems)
                    {
                        foreach (var dropDownItem in item.DropDownItems)
                        {
                            var value = dropDownItem as ToolStripMenuItem;
                            if (value != null)
                                if (!whitelistedToolStripMenuItems.Contains(value))
                                    value.Enabled = isEnabled;
                        }
                    }
                }

            buttonOn.Enabled = isEnabled;
            buttonOff.Enabled = isEnabled;
            buttonAmbiStart.Enabled = isEnabled;
        }

        private void CheckForConfiguration()
        {
            if (String.IsNullOrEmpty((string)Settings.Default["Username"]))
            {
                var reply = MessageBox.Show(
                        Resources.FormMain_CheckForConfiguration_The_Bridge_has_not_been_paired_yet__Do_you_wish_to_do_this_now__Note__Without_pairing_this_program_cannot_do_anything_,
                        Resources.FormMain_CheckForConfiguration_Not_paired_yet_, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (reply == DialogResult.Yes)
                {
                    var formConfig = new FormConfiguration();
                    formConfig.ShowDialog();

                }
                else
                {
                    return;
                }


            }
            LoadConfig();

        }

        private void LoadConfig()
        {
            //Load configuration

            try
            {
                var username = Settings.Default["Username"].ToString();
                Configuration.Initialize(username);
                //TODO Handle this better.
                ToggleControls(true);
                pairToolStripMenuItem.Enabled = false;

                LightCollection = new LightCollection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formConfig = new FormConfiguration();
            if (formConfig.ShowDialog() != DialogResult.OK)
            {
                LoadConfig();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            var lightStateBuilder = new LightStateBuilder().TurnOff();
            foreach (var light in LightCollection)
            {
                light.SetState(lightStateBuilder);
            }
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            var lightStateBuilder = new LightStateBuilder().TurnOn().Saturation(128).Brightness(128);
            foreach (var light in LightCollection)
            {
                light.SetState(lightStateBuilder);
            }
        }

        private void unpairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default["Username"] = "";
            Settings.Default.Save();

            unpairToolStripMenuItem.Enabled = false;
            var whitelistedToolStripMenuItems = new List<ToolStripMenuItem>
            {
                //TODO maybe blacklist instead
                exitToolStripMenuItem,
                aboutToolStripMenuItem,
                helpToolStripMenuItem
            };

            ToggleControls(false, whitelistedToolStripMenuItems);
            pairToolStripMenuItem.Enabled = true;
        }

        private void buttonAmbiStart_Click(object sender, EventArgs e)
        {
            buttonAmbiStart.Enabled = false;
            buttonAmbiStop.Enabled = true;
            _backgroundWorker = new BackgroundWorker();

            var screens = GetMonitorInformation();
            Screen selectedScreen = null;

            //Select the correct screen.
            foreach (var screen in screens)
            {
                if (ReferenceEquals(screen.DeviceName, comboBoxMonitors.SelectedItem))
                {
                    selectedScreen = screen;
                }
            }

            //Extract the bitmap from the monitor.
            if (selectedScreen != null)
            {
                _isAmbiRunning = true;
                _backgroundWorker.DoWork += delegate
                {
                    do
                    {
                        StartAmbi(selectedScreen);
                        GC.Collect();
                        Thread.Sleep(3000);
                    } while (_isAmbiRunning);

                };

                _backgroundWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show(Resources.FormMain_buttonAmbiStart_Click_The_selected_monitor_no_longer_exists_);
            }


        }

        private void StartAmbi(Screen selectedScreen)
        {
            var screenshot = ScreenShot(selectedScreen);
            var colorRgb = CalculateAverageColor(screenshot);
            SetAllLightsToColorHsl(colorRgb);
        }

        private void LogToTextFile(string info)
        {
            File.AppendAllText("log.txt", info + Environment.NewLine);
        }

        private void SetAllLightsToColorHsl(Color color)
        {
            var tupleXYColor = Core.GetRGBtoXY(color);
            
            var lightStateBuilder = new LightStateBuilder().TurnOn().XYCoordinates(tupleXYColor.Item1, tupleXYColor.Item2);
            foreach (var light in LightCollection)
            {
                light.SetState(lightStateBuilder);
            }
        }

        public Bitmap ScreenShot(Screen screen)
        {
            var screenShotBmp = new Bitmap(screen.Bounds.Width,
                screen.Bounds.Height, PixelFormat.Format32bppArgb);

            var screenShotGraphics = Graphics.FromImage(screenShotBmp);

            screenShotGraphics.CopyFromScreen(screen.Bounds.X,
                screen.Bounds.Y, 0, 0, screen.Bounds.Size,
                CopyPixelOperation.SourceCopy);

            screenShotGraphics.Dispose();

            return screenShotBmp;
        }

        public static Color CalculateAverageColor(Bitmap source)
        {
            BitmapData srcData = source.LockBits(
                        new Rectangle(0, 0, source.Width, source.Height),
                        ImageLockMode.ReadOnly,
                        PixelFormat.Format32bppArgb);

            int stride = srcData.Stride;

            IntPtr scan0 = srcData.Scan0;

            long[] totals = { 0, 0, 0 };

            float width = source.Width;
            float height = source.Height;

            unsafe
            {
                var p = (byte*)(void*)scan0;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        for (int color = 0; color < 3; color++)
                        {
                            int idx = (y * stride) + x * 4 + color;

                            totals[color] += p[idx];
                        }
                    }
                }
            }

            float avgB = totals[0] / (width * height);
            float avgG = totals[1] / (width * height);
            float avgR = totals[2] / (width * height);
            var avgColor = Color.FromArgb(0, (int)(avgR), (int)avgG, (int)avgB);

            return avgColor;
        }

        private void buttonAmbiStop_Click(object sender, EventArgs e)
        {
            _isAmbiRunning = false;
            buttonAmbiStart.Enabled = true;
            buttonAmbiStop.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void buttonColorLoop_Click(object sender, EventArgs e)
        {

        }



    }
}
//3dfc335e-402f-4690-a638-aac4718f8122
//TODO select which lamp is where and how many