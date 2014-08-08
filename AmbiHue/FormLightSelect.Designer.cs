namespace AmbiHue
{
    partial class FormLightSelect
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
            this.listBoxAvailableLights = new System.Windows.Forms.ListBox();
            this.listBoxSelectedLights = new System.Windows.Forms.ListBox();
            this.labelDescAvailableLights = new System.Windows.Forms.Label();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonSelectOne = new System.Windows.Forms.Button();
            this.buttonDeselectOne = new System.Windows.Forms.Button();
            this.buttonDeselectAll = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAvailableLights
            // 
            this.listBoxAvailableLights.FormattingEnabled = true;
            this.listBoxAvailableLights.Location = new System.Drawing.Point(12, 25);
            this.listBoxAvailableLights.Name = "listBoxAvailableLights";
            this.listBoxAvailableLights.Size = new System.Drawing.Size(120, 225);
            this.listBoxAvailableLights.TabIndex = 0;
            // 
            // listBoxSelectedLights
            // 
            this.listBoxSelectedLights.FormattingEnabled = true;
            this.listBoxSelectedLights.Location = new System.Drawing.Point(219, 25);
            this.listBoxSelectedLights.Name = "listBoxSelectedLights";
            this.listBoxSelectedLights.Size = new System.Drawing.Size(120, 225);
            this.listBoxSelectedLights.TabIndex = 1;
            // 
            // labelDescAvailableLights
            // 
            this.labelDescAvailableLights.AutoSize = true;
            this.labelDescAvailableLights.Location = new System.Drawing.Point(9, 9);
            this.labelDescAvailableLights.Name = "labelDescAvailableLights";
            this.labelDescAvailableLights.Size = new System.Drawing.Size(77, 13);
            this.labelDescAvailableLights.TabIndex = 2;
            this.labelDescAvailableLights.Text = "Available lights";
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Location = new System.Drawing.Point(138, 53);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAll.TabIndex = 3;
            this.buttonSelectAll.Text = ">>";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonSelectOne
            // 
            this.buttonSelectOne.Location = new System.Drawing.Point(138, 82);
            this.buttonSelectOne.Name = "buttonSelectOne";
            this.buttonSelectOne.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectOne.TabIndex = 4;
            this.buttonSelectOne.Text = ">";
            this.buttonSelectOne.UseVisualStyleBackColor = true;
            this.buttonSelectOne.Click += new System.EventHandler(this.buttonSelectOne_Click);
            // 
            // buttonDeselectOne
            // 
            this.buttonDeselectOne.Location = new System.Drawing.Point(138, 111);
            this.buttonDeselectOne.Name = "buttonDeselectOne";
            this.buttonDeselectOne.Size = new System.Drawing.Size(75, 23);
            this.buttonDeselectOne.TabIndex = 5;
            this.buttonDeselectOne.Text = "<";
            this.buttonDeselectOne.UseVisualStyleBackColor = true;
            this.buttonDeselectOne.Click += new System.EventHandler(this.buttonDeselectOne_Click);
            // 
            // buttonDeselectAll
            // 
            this.buttonDeselectAll.Location = new System.Drawing.Point(138, 140);
            this.buttonDeselectAll.Name = "buttonDeselectAll";
            this.buttonDeselectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonDeselectAll.TabIndex = 6;
            this.buttonDeselectAll.Text = "<<";
            this.buttonDeselectAll.UseVisualStyleBackColor = true;
            this.buttonDeselectAll.Click += new System.EventHandler(this.buttonDeselectAll_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(264, 256);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(183, 256);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 8;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // FormLightSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 292);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDeselectAll);
            this.Controls.Add(this.buttonDeselectOne);
            this.Controls.Add(this.buttonSelectOne);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.labelDescAvailableLights);
            this.Controls.Add(this.listBoxSelectedLights);
            this.Controls.Add(this.listBoxAvailableLights);
            this.Name = "FormLightSelect";
            this.Text = "Select lights";
            this.Load += new System.EventHandler(this.FormLightSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAvailableLights;
        private System.Windows.Forms.ListBox listBoxSelectedLights;
        private System.Windows.Forms.Label labelDescAvailableLights;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonSelectOne;
        private System.Windows.Forms.Button buttonDeselectOne;
        private System.Windows.Forms.Button buttonDeselectAll;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSelect;
    }
}