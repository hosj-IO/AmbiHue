using System;
using System.Collections.Generic;
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
        private bool _isToggled;

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
            CheckForConfiguration();
        }

        private void ToggleControls(bool isEnabled, List<ToolStripMenuItem> whitelistedToolStripMenuItems)
        {
            if (menuStripMain != null)
                foreach (ToolStripMenuItem item in menuStripMain.Items)
                {
                    if (item.HasDropDownItems)
                    {
                        foreach (ToolStripMenuItem dropDownItem in item.DropDownItems)
                        {
                            if (!whitelistedToolStripMenuItems.Contains(dropDownItem))
                                dropDownItem.Enabled = isEnabled;
                        }
                    }
                }
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
                toggleOnOffToolStripMenuItem.Enabled = true;
                userOverviewToolStripMenuItem.Enabled = true;
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

        private void toggleOnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_isToggled)
            {
                var lightStateBuilder = new LightStateBuilder().TurnOn().Saturation(128).Brightness(128);
                foreach (var light in LightCollection)
                {
                    light.SetState(lightStateBuilder);
                }
            }
            else
            {
                var lightStateBuilder = new LightStateBuilder().TurnOff();
                foreach (var light in LightCollection)
                {
                    light.SetState(lightStateBuilder);
                }
            }
            _isToggled = !_isToggled;
        }

    }
}
