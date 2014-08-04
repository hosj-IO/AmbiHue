using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AmbiHue.Properties;
using SharpHue;
using SharpHue.Utilities;

namespace AmbiHue
{
    public partial class FormUserOverview : Form
    {
        public FormUserOverview()
        {
            InitializeComponent();
        }

        private void FormUserOverview_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            listBoxUsers.DataSource = LoadUserList();
            textBoxID.Enabled = false;
        }

        private List<WhitelistItem> LoadUserList()
        {
            return Configuration.Whitelist();
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedWhitelistItem = (WhitelistItem)listBoxUsers.SelectedItem;
            textBoxID.Text = selectedWhitelistItem.ID;
            textBoxName.Text = selectedWhitelistItem.Name;
            textBoxDateCreate.Text = selectedWhitelistItem.CreateDate;
            textBoxDateLastUsed.Text = selectedWhitelistItem.LastUseDate;
        }

        private void checkBoxChangeID_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxChangeID_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(Resources.FormUserOverview_checkBoxChangeID_Click_Changing_the_ID_will_cause_problems_with_the_program_using_the_ID__Use_caution__Do_wish_to_change_it_,
    Resources.FormUserOverview_checkBoxChangeID_Click_Changing_ID, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                textBoxID.Enabled = true;
                checkBoxChangeID.Checked = true;
            }
            else
            {
                checkBoxChangeID.Checked = false;
                textBoxID.Enabled = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var selectedWhitelistItem = (WhitelistItem)listBoxUsers.SelectedItem;
            selectedWhitelistItem.Save();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedWhitelistItem = (WhitelistItem)listBoxUsers.SelectedItem;
            selectedWhitelistItem.Delete();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            //TODO
        }

    }
}
//todo add redbackground to not used in a week or something