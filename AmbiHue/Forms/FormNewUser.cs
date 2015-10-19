using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpHue;

namespace AmbiHue
{
    public partial class FormNewUser : Form
    {
        public FormNewUser()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormNewUser_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            textBoxID.Enabled = false;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != null)
            {

                if (textBoxID.Text == string.Empty)
                {
                    Configuration.AddUser(textBoxName.Text);
                }
                //else
                //{
                //    Configuration.AddUser(textBoxName.Text, textBoxID.Text);
                //}
                
                Close();
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            textBoxID.Text = Guid.NewGuid().ToString();
        }

    }
}
