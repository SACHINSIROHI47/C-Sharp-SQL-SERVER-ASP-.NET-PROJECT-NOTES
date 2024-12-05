using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp180716_E4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            cmbCity.Items.Add(txtCity.Text);
            cmbCity.Sorted = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCity.Items.Add("Anupshaahar");
            cmbCity.Items.Add("Muraina");
            cmbCity.Items.Add("Pauri");
            cmbCity.Items.Add("Mussoorie");
        }
    }
}
