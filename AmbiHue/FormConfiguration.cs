using System;
using System.Windows.Forms;
using AmbiHue.Properties;

namespace AmbiHue
{
    public partial class FormConfiguration : Form
    {
        public FormConfiguration()
        {
            InitializeComponent();
        }

        private void FormConfiguration_Load(object sender, EventArgs e)
        {
            labelInfoBridge.Text = Resources.FormConfiguration_FormConfiguration_Load_Press_the_button_on_the_bridge__Once_you_have_done_this_click_on_the_pair_button_below_;
        }

        private void buttonPair_Click(object sender, EventArgs e)
        {
            try
            {
                SharpHue.Configuration.AddUser("SiberHue");
                Settings.Default["Username"] = SharpHue.Configuration.Username;
                Settings.Default.Save();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
