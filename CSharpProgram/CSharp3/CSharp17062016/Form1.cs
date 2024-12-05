using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp17062016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("State is " + lstState.SelectedItem.ToString());
        }

        private void btnFacilities_Click(object sender, EventArgs e)
        {
            foreach (var SelectedValue in chkLstFacility.CheckedItems)
            {
                MessageBox.Show(SelectedValue.ToString());
            }
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Date is " + dtpTransactionDate.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCity.Items.Add("Dehradun");
            cmbCity.Items.Add("Rishikeh");
            cmbCity.Items.Add("Haridwar");
            cmbCity.Items.Add("Pauri");
            cmbCity.Items.Add("Grahwal");
            MessageBox.Show("Welcome To SBI");

        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            MessageBox.Show("City is " + cmbCity.Text);
        }

        private void btnDateOfBirth_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Date of Birth is " + mcDateOfBirth.SelectionEnd.ToString());
        }
    }
}
