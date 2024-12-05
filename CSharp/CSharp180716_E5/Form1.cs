using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp180716_E5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbState.Items.Add("Uttar Pradesh");
            cmbState.Items.Add("Uttarakhand");
            cmbState.Items.Add("Maharashtra");
            cmbState.Items.Add("Rajasthan");
            cmbState.Sorted = true;
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbState.Text.Length == 0)
            {
                MessageBox.Show("Plese Select The state");
            }
            else if (cmbState.Text =="Uttar Pradesh")
            {
                cmbCity.Items.Clear();
                cmbCity.Items.Add("Meerut");
                cmbCity.Items.Add("Kanpur");
                cmbCity.Items.Add("Noida");
                cmbCity.Items.Add("Hapur");
                cmbCity.Sorted = true;
            }
            else if (cmbState.Text == "Uttarakhand")
            {
                cmbCity.Items.Clear();
                cmbCity.Items.Add("Dehradun");
                cmbCity.Items.Add("Haridwar");
                cmbCity.Items.Add("Nainital");
                cmbCity.Items.Add("Pauri");
                cmbCity.Sorted = true;
            }
            else if (cmbState.Text == "Maharashtra")
            {
                cmbCity.Items.Clear();
                cmbCity.Items.Add("Mumbai");
                cmbCity.Items.Add("Pune");
                cmbCity.Items.Add("Aurangabad");
                cmbCity.Items.Add("Nagpur");
                cmbCity.Sorted = true;
            }
            else if (cmbState.Text == "Rajasthan")
            {
                cmbCity.Items.Clear();
                cmbCity.Items.Add("Jaipur");
                cmbCity.Items.Add("Ajmer");
                cmbCity.Items.Add("Pushkar");
                cmbCity.Items.Add("Mountabu");
                cmbCity.Sorted = true;
            }
            else
            {
                MessageBox.Show("Invalid state");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbState.Text.Length == 0)
            {
                MessageBox.Show("Please select the State");
            }
            else if (cmbCity.Text.Length == 0)
            {
                MessageBox.Show("Please select the City");
            }
            else
            {
                MessageBox.Show("State : " + cmbState.SelectedItem.ToString() +
               "\nCity : " + cmbCity.SelectedItem.ToString());
            }
        }
    }
}
