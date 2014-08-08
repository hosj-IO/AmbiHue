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
        private readonly string _username;
        public FormUserOverview(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void FormUserOverview_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            PopulateListBoxUser();
            textBoxID.Enabled = false;
            buttonNew.Enabled = false;
        }

        private void PopulateListBoxUser()
        {
            listBoxUsers.DataSource = LoadUserList();
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


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedWhitelistItem = (WhitelistItem)listBoxUsers.SelectedItem;
            if (selectedWhitelistItem.ID != _username)
            {
                var result = selectedWhitelistItem.Delete(_username);
                if (result)
                {
                    PopulateListBoxUser();
                }
                else
                {
                    MessageBox.Show(Resources.FormUserOverview_buttonDelete_Click_Could_not_delete_user_);
                }
            }
            else
            {
                MessageBox.Show(Resources.FormUserOverview_buttonDelete_Click_Cannot_delete_the_currently_used_user_);
            }

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            var formNewUser = new FormNewUser();
            formNewUser.ShowDialog();
            PopulateListBoxUser();
        }
    }
}
//todo add redbackground to not used in a week or something