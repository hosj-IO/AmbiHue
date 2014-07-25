namespace AmbiHue
{
    partial class FormConfiguration
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelInfoBridge = new System.Windows.Forms.Label();
            this.buttonPair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AmbiHue.Properties.Resources.bridgePointPaint;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 417);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelInfoBridge
            // 
            this.labelInfoBridge.AutoSize = true;
            this.labelInfoBridge.Location = new System.Drawing.Point(521, 12);
            this.labelInfoBridge.Name = "labelInfoBridge";
            this.labelInfoBridge.Size = new System.Drawing.Size(29, 13);
            this.labelInfoBridge.TabIndex = 1;
            this.labelInfoBridge.Text = "label";
            // 
            // buttonPair
            // 
            this.buttonPair.Location = new System.Drawing.Point(521, 28);
            this.buttonPair.Name = "buttonPair";
            this.buttonPair.Size = new System.Drawing.Size(75, 23);
            this.buttonPair.TabIndex = 2;
            this.buttonPair.Text = "Pair";
            this.buttonPair.UseVisualStyleBackColor = true;
            this.buttonPair.Click += new System.EventHandler(this.buttonPair_Click);
            // 
            // FormConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 438);
            this.Controls.Add(this.buttonPair);
            this.Controls.Add(this.labelInfoBridge);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormConfiguration";
            this.Text = "Pair with the bridge!";
            this.Load += new System.EventHandler(this.FormConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelInfoBridge;
        private System.Windows.Forms.Button buttonPair;
    }
}