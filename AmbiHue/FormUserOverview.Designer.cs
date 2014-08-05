namespace AmbiHue
{
    partial class FormUserOverview
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
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDateCreate = new System.Windows.Forms.TextBox();
            this.textBoxDateLastUsed = new System.Windows.Forms.TextBox();
            this.labelDescID = new System.Windows.Forms.Label();
            this.labelDescName = new System.Windows.Forms.Label();
            this.labelDescCreateDate = new System.Windows.Forms.Label();
            this.labelDescDateLastUsed = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(12, 12);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(270, 381);
            this.listBoxUsers.TabIndex = 0;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(375, 9);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(249, 20);
            this.textBoxID.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(375, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(249, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxDateCreate
            // 
            this.textBoxDateCreate.Location = new System.Drawing.Point(375, 59);
            this.textBoxDateCreate.Name = "textBoxDateCreate";
            this.textBoxDateCreate.Size = new System.Drawing.Size(249, 20);
            this.textBoxDateCreate.TabIndex = 3;
            // 
            // textBoxDateLastUsed
            // 
            this.textBoxDateLastUsed.Location = new System.Drawing.Point(375, 85);
            this.textBoxDateLastUsed.Name = "textBoxDateLastUsed";
            this.textBoxDateLastUsed.Size = new System.Drawing.Size(249, 20);
            this.textBoxDateLastUsed.TabIndex = 4;
            // 
            // labelDescID
            // 
            this.labelDescID.AutoSize = true;
            this.labelDescID.Location = new System.Drawing.Point(345, 12);
            this.labelDescID.Name = "labelDescID";
            this.labelDescID.Size = new System.Drawing.Size(21, 13);
            this.labelDescID.TabIndex = 5;
            this.labelDescID.Text = "ID:";
            // 
            // labelDescName
            // 
            this.labelDescName.AutoSize = true;
            this.labelDescName.Location = new System.Drawing.Point(328, 38);
            this.labelDescName.Name = "labelDescName";
            this.labelDescName.Size = new System.Drawing.Size(38, 13);
            this.labelDescName.TabIndex = 6;
            this.labelDescName.Text = "Name:";
            // 
            // labelDescCreateDate
            // 
            this.labelDescCreateDate.AutoSize = true;
            this.labelDescCreateDate.Location = new System.Drawing.Point(294, 62);
            this.labelDescCreateDate.Name = "labelDescCreateDate";
            this.labelDescCreateDate.Size = new System.Drawing.Size(75, 13);
            this.labelDescCreateDate.TabIndex = 7;
            this.labelDescCreateDate.Text = "Date created: ";
            // 
            // labelDescDateLastUsed
            // 
            this.labelDescDateLastUsed.AutoSize = true;
            this.labelDescDateLastUsed.Location = new System.Drawing.Point(291, 88);
            this.labelDescDateLastUsed.Name = "labelDescDateLastUsed";
            this.labelDescDateLastUsed.Size = new System.Drawing.Size(78, 13);
            this.labelDescDateLastUsed.TabIndex = 8;
            this.labelDescDateLastUsed.Text = "Date last used:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(375, 111);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(375, 220);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 13;
            this.buttonNew.Text = "Add New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // FormUserOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 409);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelDescDateLastUsed);
            this.Controls.Add(this.labelDescCreateDate);
            this.Controls.Add(this.labelDescName);
            this.Controls.Add(this.labelDescID);
            this.Controls.Add(this.textBoxDateLastUsed);
            this.Controls.Add(this.textBoxDateCreate);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.listBoxUsers);
            this.Name = "FormUserOverview";
            this.Text = "User Overview";
            this.Load += new System.EventHandler(this.FormUserOverview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDateCreate;
        private System.Windows.Forms.TextBox textBoxDateLastUsed;
        private System.Windows.Forms.Label labelDescID;
        private System.Windows.Forms.Label labelDescName;
        private System.Windows.Forms.Label labelDescCreateDate;
        private System.Windows.Forms.Label labelDescDateLastUsed;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNew;
    }
}