using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SharpHue;

namespace AmbiHue
{
    public partial class FormLightSelect : Form
    {
        private LightCollection _lightCollection;
        public List<Light> Lights;

        public FormLightSelect()
        {
            InitializeComponent();
        }

        private void FormLightSelect_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            _lightCollection = new LightCollection();
            PopulateListBox(listBoxAvailableLights, _lightCollection.ToList());
        }

        private void PopulateListBox(ListBox listBox, List<Light> lights)
        {
            foreach (var light in lights)
            {
                listBox.Items.Add(light);
            }
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            listBoxSelectedLights.Items.Clear();
            listBoxAvailableLights.Items.Clear();
            PopulateListBox(listBoxSelectedLights, _lightCollection.ToList());
        }

        private void buttonDeselectAll_Click(object sender, EventArgs e)
        {
            listBoxSelectedLights.Items.Clear();
            listBoxAvailableLights.Items.Clear();
            PopulateListBox(listBoxAvailableLights, _lightCollection.ToList());
        }

        private void buttonSelectOne_Click(object sender, EventArgs e)
        {
            if (listBoxAvailableLights.SelectedItem != null)
            {
                listBoxSelectedLights.Items.Add(listBoxAvailableLights.SelectedItem);
                listBoxAvailableLights.Items.Remove(listBoxAvailableLights.SelectedItem);
            }
        }

        private void buttonDeselectOne_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedLights.SelectedItem != null)
            {
                listBoxAvailableLights.Items.Add(listBoxSelectedLights.SelectedItem);
                listBoxSelectedLights.Items.Remove(listBoxSelectedLights.SelectedItem);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            //Is this most efficient?
            Lights = new List<Light>();
            foreach (var item in listBoxSelectedLights.Items)
            {
                var test = (Light) item;
                Lights.Add(test);
            }
            Close();
        }
    }
}
