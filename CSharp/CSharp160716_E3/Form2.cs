using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp160716_E3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("State is " + cmbState.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbCity.Items.Add("Dehradun");
            cmbCity.Items.Add("Rishikeh");
            cmbCity.Items.Add("Haridwar");
            cmbCity.Items.Add("Pauri");
            cmbCity.Items.Add("Grahwal");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("City is " + cmbCity.Text);
        }
    }
}
