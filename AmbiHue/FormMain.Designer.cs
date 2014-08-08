namespace AmbiHue
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bridgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.unpairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOn = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.comboBoxMonitors = new System.Windows.Forms.ComboBox();
            this.buttonAmbiStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAmbiStop = new System.Windows.Forms.Button();
            this.tabControlHuePages = new System.Windows.Forms.TabControl();
            this.tabPageAmbi = new System.Windows.Forms.TabPage();
            this.labelAmbiSeconds = new System.Windows.Forms.Label();
            this.trackBarAmbiSeconds = new System.Windows.Forms.TrackBar();
            this.tabPageLightControl = new System.Windows.Forms.TabPage();
            this.buttonTurnLightOff = new System.Windows.Forms.Button();
            this.buttonApplyColorLight = new System.Windows.Forms.Button();
            this.labelPreviewColor = new System.Windows.Forms.Label();
            this.pictureBoxColorPreviewLight = new System.Windows.Forms.PictureBox();
            this.buttonLightColorSelect = new System.Windows.Forms.Button();
            this.labelLightsControl = new System.Windows.Forms.Label();
            this.trackBarLights = new System.Windows.Forms.TrackBar();
            this.tabPageCustom = new System.Windows.Forms.TabPage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColorLoop = new System.Windows.Forms.Button();
            this.searchForNewLightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonSelectLights = new System.Windows.Forms.Button();
            this.listBoxSelectedLights = new System.Windows.Forms.ListBox();
            this.menuStripMain.SuspendLayout();
            this.tabControlHuePages.SuspendLayout();
            this.tabPageAmbi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmbiSeconds)).BeginInit();
            this.tabPageLightControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorPreviewLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLights)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bridgeToolStripMenuItem,
            this.mainHelpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(590, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bridgeToolStripMenuItem
            // 
            this.bridgeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pairToolStripMenuItem,
            this.toolStripSeparator2,
            this.searchForNewLightsToolStripMenuItem,
            this.userOverviewToolStripMenuItem,
            this.toolStripSeparator1,
            this.unpairToolStripMenuItem});
            this.bridgeToolStripMenuItem.Name = "bridgeToolStripMenuItem";
            this.bridgeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.bridgeToolStripMenuItem.Text = "&Bridge";
            // 
            // pairToolStripMenuItem
            // 
            this.pairToolStripMenuItem.Name = "pairToolStripMenuItem";
            this.pairToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.pairToolStripMenuItem.Text = "&Pair";
            this.pairToolStripMenuItem.Click += new System.EventHandler(this.pairToolStripMenuItem_Click);
            // 
            // userOverviewToolStripMenuItem
            // 
            this.userOverviewToolStripMenuItem.Enabled = false;
            this.userOverviewToolStripMenuItem.Name = "userOverviewToolStripMenuItem";
            this.userOverviewToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.userOverviewToolStripMenuItem.Text = "&User overview";
            this.userOverviewToolStripMenuItem.Click += new System.EventHandler(this.userOverviewToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // unpairToolStripMenuItem
            // 
            this.unpairToolStripMenuItem.Name = "unpairToolStripMenuItem";
            this.unpairToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.unpairToolStripMenuItem.Text = "&Unpair";
            this.unpairToolStripMenuItem.Click += new System.EventHandler(this.unpairToolStripMenuItem_Click);
            // 
            // mainHelpToolStripMenuItem
            // 
            this.mainHelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainHelpToolStripMenuItem.Name = "mainHelpToolStripMenuItem";
            this.mainHelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.mainHelpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "&Check for updates";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonOn
            // 
            this.buttonOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOn.ForeColor = System.Drawing.Color.Green;
            this.buttonOn.Location = new System.Drawing.Point(12, 27);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(95, 68);
            this.buttonOn.TabIndex = 2;
            this.buttonOn.Text = "On";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // buttonOff
            // 
            this.buttonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOff.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonOff.Location = new System.Drawing.Point(113, 27);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(95, 68);
            this.buttonOff.TabIndex = 3;
            this.buttonOff.Text = "Off";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // comboBoxMonitors
            // 
            this.comboBoxMonitors.FormattingEnabled = true;
            this.comboBoxMonitors.Location = new System.Drawing.Point(6, 6);
            this.comboBoxMonitors.Name = "comboBoxMonitors";
            this.comboBoxMonitors.Size = new System.Drawing.Size(196, 21);
            this.comboBoxMonitors.TabIndex = 4;
            // 
            // buttonAmbiStart
            // 
            this.buttonAmbiStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAmbiStart.ForeColor = System.Drawing.Color.Green;
            this.buttonAmbiStart.Location = new System.Drawing.Point(107, 112);
            this.buttonAmbiStart.Name = "buttonAmbiStart";
            this.buttonAmbiStart.Size = new System.Drawing.Size(95, 68);
            this.buttonAmbiStart.TabIndex = 5;
            this.buttonAmbiStart.Text = "Start";
            this.buttonAmbiStart.UseVisualStyleBackColor = true;
            this.buttonAmbiStart.Click += new System.EventHandler(this.buttonAmbiStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "To start Ambi:\r\nSelect a monitor.\r\nClick on start.";
            // 
            // buttonAmbiStop
            // 
            this.buttonAmbiStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAmbiStop.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonAmbiStop.Location = new System.Drawing.Point(107, 186);
            this.buttonAmbiStop.Name = "buttonAmbiStop";
            this.buttonAmbiStop.Size = new System.Drawing.Size(95, 68);
            this.buttonAmbiStop.TabIndex = 7;
            this.buttonAmbiStop.Text = "Stop";
            this.buttonAmbiStop.UseVisualStyleBackColor = true;
            this.buttonAmbiStop.Click += new System.EventHandler(this.buttonAmbiStop_Click);
            // 
            // tabControlHuePages
            // 
            this.tabControlHuePages.Controls.Add(this.tabPageAmbi);
            this.tabControlHuePages.Controls.Add(this.tabPageLightControl);
            this.tabControlHuePages.Controls.Add(this.tabPageCustom);
            this.tabControlHuePages.Location = new System.Drawing.Point(12, 101);
            this.tabControlHuePages.Name = "tabControlHuePages";
            this.tabControlHuePages.SelectedIndex = 0;
            this.tabControlHuePages.Size = new System.Drawing.Size(566, 435);
            this.tabControlHuePages.TabIndex = 8;
            // 
            // tabPageAmbi
            // 
            this.tabPageAmbi.Controls.Add(this.listBoxSelectedLights);
            this.tabPageAmbi.Controls.Add(this.buttonSelectLights);
            this.tabPageAmbi.Controls.Add(this.labelAmbiSeconds);
            this.tabPageAmbi.Controls.Add(this.trackBarAmbiSeconds);
            this.tabPageAmbi.Controls.Add(this.buttonAmbiStop);
            this.tabPageAmbi.Controls.Add(this.buttonAmbiStart);
            this.tabPageAmbi.Controls.Add(this.label1);
            this.tabPageAmbi.Controls.Add(this.comboBoxMonitors);
            this.tabPageAmbi.Location = new System.Drawing.Point(4, 22);
            this.tabPageAmbi.Name = "tabPageAmbi";
            this.tabPageAmbi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAmbi.Size = new System.Drawing.Size(558, 409);
            this.tabPageAmbi.TabIndex = 0;
            this.tabPageAmbi.Text = "Ambi Control";
            this.tabPageAmbi.UseVisualStyleBackColor = true;
            // 
            // labelAmbiSeconds
            // 
            this.labelAmbiSeconds.AutoSize = true;
            this.labelAmbiSeconds.Location = new System.Drawing.Point(217, 38);
            this.labelAmbiSeconds.Name = "labelAmbiSeconds";
            this.labelAmbiSeconds.Size = new System.Drawing.Size(35, 13);
            this.labelAmbiSeconds.TabIndex = 11;
            this.labelAmbiSeconds.Text = "label2";
            // 
            // trackBarAmbiSeconds
            // 
            this.trackBarAmbiSeconds.Location = new System.Drawing.Point(208, 6);
            this.trackBarAmbiSeconds.Name = "trackBarAmbiSeconds";
            this.trackBarAmbiSeconds.Size = new System.Drawing.Size(344, 45);
            this.trackBarAmbiSeconds.TabIndex = 10;
            this.trackBarAmbiSeconds.Scroll += new System.EventHandler(this.trackBarAmbiSeconds_Scroll);
            // 
            // tabPageLightControl
            // 
            this.tabPageLightControl.Controls.Add(this.buttonTurnLightOff);
            this.tabPageLightControl.Controls.Add(this.buttonApplyColorLight);
            this.tabPageLightControl.Controls.Add(this.labelPreviewColor);
            this.tabPageLightControl.Controls.Add(this.pictureBoxColorPreviewLight);
            this.tabPageLightControl.Controls.Add(this.buttonLightColorSelect);
            this.tabPageLightControl.Controls.Add(this.labelLightsControl);
            this.tabPageLightControl.Controls.Add(this.trackBarLights);
            this.tabPageLightControl.Location = new System.Drawing.Point(4, 22);
            this.tabPageLightControl.Name = "tabPageLightControl";
            this.tabPageLightControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLightControl.Size = new System.Drawing.Size(558, 409);
            this.tabPageLightControl.TabIndex = 1;
            this.tabPageLightControl.Text = "Light Control";
            this.tabPageLightControl.UseVisualStyleBackColor = true;
            // 
            // buttonTurnLightOff
            // 
            this.buttonTurnLightOff.Location = new System.Drawing.Point(87, 121);
            this.buttonTurnLightOff.Name = "buttonTurnLightOff";
            this.buttonTurnLightOff.Size = new System.Drawing.Size(75, 23);
            this.buttonTurnLightOff.TabIndex = 14;
            this.buttonTurnLightOff.Text = "Turn off";
            this.buttonTurnLightOff.UseVisualStyleBackColor = true;
            this.buttonTurnLightOff.Click += new System.EventHandler(this.buttonTurnLightOff_Click);
            // 
            // buttonApplyColorLight
            // 
            this.buttonApplyColorLight.Enabled = false;
            this.buttonApplyColorLight.Location = new System.Drawing.Point(6, 122);
            this.buttonApplyColorLight.Name = "buttonApplyColorLight";
            this.buttonApplyColorLight.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyColorLight.TabIndex = 13;
            this.buttonApplyColorLight.Text = "Apply Color";
            this.buttonApplyColorLight.UseVisualStyleBackColor = true;
            this.buttonApplyColorLight.Click += new System.EventHandler(this.buttonApplyColorLight_Click);
            // 
            // labelPreviewColor
            // 
            this.labelPreviewColor.AutoSize = true;
            this.labelPreviewColor.Location = new System.Drawing.Point(6, 93);
            this.labelPreviewColor.Name = "labelPreviewColor";
            this.labelPreviewColor.Size = new System.Drawing.Size(74, 13);
            this.labelPreviewColor.TabIndex = 12;
            this.labelPreviewColor.Text = "Preview color:";
            // 
            // pictureBoxColorPreviewLight
            // 
            this.pictureBoxColorPreviewLight.Location = new System.Drawing.Point(86, 93);
            this.pictureBoxColorPreviewLight.Name = "pictureBoxColorPreviewLight";
            this.pictureBoxColorPreviewLight.Size = new System.Drawing.Size(28, 22);
            this.pictureBoxColorPreviewLight.TabIndex = 11;
            this.pictureBoxColorPreviewLight.TabStop = false;
            // 
            // buttonLightColorSelect
            // 
            this.buttonLightColorSelect.Location = new System.Drawing.Point(6, 67);
            this.buttonLightColorSelect.Name = "buttonLightColorSelect";
            this.buttonLightColorSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonLightColorSelect.TabIndex = 10;
            this.buttonLightColorSelect.Text = "Select Color";
            this.buttonLightColorSelect.UseVisualStyleBackColor = true;
            this.buttonLightColorSelect.Click += new System.EventHandler(this.buttonLightColorSelect_Click);
            // 
            // labelLightsControl
            // 
            this.labelLightsControl.AutoSize = true;
            this.labelLightsControl.Location = new System.Drawing.Point(6, 38);
            this.labelLightsControl.Name = "labelLightsControl";
            this.labelLightsControl.Size = new System.Drawing.Size(35, 13);
            this.labelLightsControl.TabIndex = 1;
            this.labelLightsControl.Text = "label2";
            // 
            // trackBarLights
            // 
            this.trackBarLights.Location = new System.Drawing.Point(6, 6);
            this.trackBarLights.Name = "trackBarLights";
            this.trackBarLights.Size = new System.Drawing.Size(546, 45);
            this.trackBarLights.TabIndex = 0;
            this.trackBarLights.Scroll += new System.EventHandler(this.trackBarLights_Scroll);
            // 
            // tabPageCustom
            // 
            this.tabPageCustom.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustom.Name = "tabPageCustom";
            this.tabPageCustom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustom.Size = new System.Drawing.Size(558, 409);
            this.tabPageCustom.TabIndex = 2;
            this.tabPageCustom.Text = "Custom";
            this.tabPageCustom.UseVisualStyleBackColor = true;
            // 
            // buttonColorLoop
            // 
            this.buttonColorLoop.Enabled = false;
            this.buttonColorLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColorLoop.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonColorLoop.Location = new System.Drawing.Point(214, 27);
            this.buttonColorLoop.Name = "buttonColorLoop";
            this.buttonColorLoop.Size = new System.Drawing.Size(95, 68);
            this.buttonColorLoop.TabIndex = 9;
            this.buttonColorLoop.Text = "Color Loop";
            this.buttonColorLoop.UseVisualStyleBackColor = true;
            this.buttonColorLoop.Click += new System.EventHandler(this.buttonColorLoop_Click);
            // 
            // searchForNewLightsToolStripMenuItem
            // 
            this.searchForNewLightsToolStripMenuItem.Name = "searchForNewLightsToolStripMenuItem";
            this.searchForNewLightsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.searchForNewLightsToolStripMenuItem.Text = "Search for new lights";
            this.searchForNewLightsToolStripMenuItem.Click += new System.EventHandler(this.searchForNewLightsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // buttonSelectLights
            // 
            this.buttonSelectLights.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectLights.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonSelectLights.Location = new System.Drawing.Point(107, 38);
            this.buttonSelectLights.Name = "buttonSelectLights";
            this.buttonSelectLights.Size = new System.Drawing.Size(95, 68);
            this.buttonSelectLights.TabIndex = 12;
            this.buttonSelectLights.Text = "Select Lights";
            this.buttonSelectLights.UseVisualStyleBackColor = true;
            this.buttonSelectLights.Click += new System.EventHandler(this.buttonSelectLights_Click);
            // 
            // listBoxSelectedLights
            // 
            this.listBoxSelectedLights.FormattingEnabled = true;
            this.listBoxSelectedLights.Location = new System.Drawing.Point(208, 67);
            this.listBoxSelectedLights.Name = "listBoxSelectedLights";
            this.listBoxSelectedLights.Size = new System.Drawing.Size(185, 186);
            this.listBoxSelectedLights.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 548);
            this.Controls.Add(this.buttonColorLoop);
            this.Controls.Add(this.tabControlHuePages);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.buttonOn);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "AmbiHue";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControlHuePages.ResumeLayout(false);
            this.tabPageAmbi.ResumeLayout(false);
            this.tabPageAmbi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmbiSeconds)).EndInit();
            this.tabPageLightControl.ResumeLayout(false);
            this.tabPageLightControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorPreviewLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bridgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userOverviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem unpairToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxMonitors;
        private System.Windows.Forms.Button buttonAmbiStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAmbiStop;
        private System.Windows.Forms.TabControl tabControlHuePages;
        private System.Windows.Forms.TabPage tabPageAmbi;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonColorLoop;
        private System.Windows.Forms.TabPage tabPageLightControl;
        private System.Windows.Forms.TrackBar trackBarLights;
        private System.Windows.Forms.TabPage tabPageCustom;
        private System.Windows.Forms.Label labelLightsControl;
        private System.Windows.Forms.Button buttonLightColorSelect;
        private System.Windows.Forms.PictureBox pictureBoxColorPreviewLight;
        private System.Windows.Forms.Label labelPreviewColor;
        private System.Windows.Forms.Button buttonApplyColorLight;
        private System.Windows.Forms.Button buttonTurnLightOff;
        private System.Windows.Forms.TrackBar trackBarAmbiSeconds;
        private System.Windows.Forms.Label labelAmbiSeconds;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem searchForNewLightsToolStripMenuItem;
        private System.Windows.Forms.Button buttonSelectLights;
        private System.Windows.Forms.ListBox listBoxSelectedLights;

    }
}

