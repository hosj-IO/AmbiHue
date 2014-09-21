using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AmbiHue.Properties;
using SharpHue;
using SharpHue.Config;

namespace AmbiHue
{
    public partial class FormUserOverview : Form
    {
        private string _username;
        private SharpHue.Config.Configuration _configuration;


        public FormUserOverview(string username)
        {
            InitializeComponent();
            _username = username;
            GetConfiguration();
        }

        private void GetConfiguration()
        {
            _configuration = SharpHue.Configuration.GetBridgeConfiguration();
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
            GetConfiguration();
            var dictionaryWhitelist = LoadUserList();
            var whitelistList = new List<Classes.LocalWhitelistItem>();
            foreach (var item in dictionaryWhitelist)
            {
                var localItem = new Classes.LocalWhitelistItem();
                localItem.ApplicationID = item.Value.ApplicationID;
                localItem.Created = item.Value.Created;
                localItem.LastUsed = item.Value.LastUsed;
                localItem.UniqueID = item.Key;
                whitelistList.Add(localItem);
            }

            listBoxUsers.DataSource = whitelistList;
        }

        private Dictionary<string,WhitelistItem> LoadUserList()
        {
            return _configuration.Whitelist;
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedWhitelistItem = (Classes.LocalWhitelistItem)listBoxUsers.SelectedItem;
            textBoxID.Text = selectedWhitelistItem.UniqueID;
            textBoxName.Text = selectedWhitelistItem.ApplicationID; 
            textBoxDateCreate.Text = selectedWhitelistItem.Created.ToShortDateString();
            textBoxDateLastUsed.Text = selectedWhitelistItem.LastUsed.ToShortDateString();
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {

            var selectedWhitelistItem = (Classes.LocalWhitelistItem)listBoxUsers.SelectedItem;
            if (selectedWhitelistItem.UniqueID != _username)
            {
                var result = SharpHue.Configuration.DeleteUser(selectedWhitelistItem.UniqueID);
                if (result)
                {
                    PopulateListBoxUser();
                }
                else
                {
                    MessageBox.Show("Could not delete");
                }
            }
            else
            {
                MessageBox.Show("Cannot delete currently used username.");
            }

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            var formNewUser = new FormNewUser();
            formNewUser.ShowDialog();
            PopulateListBoxUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateListBoxUser();
        }
    }
}
//todo add redbackground to not used in a week or something