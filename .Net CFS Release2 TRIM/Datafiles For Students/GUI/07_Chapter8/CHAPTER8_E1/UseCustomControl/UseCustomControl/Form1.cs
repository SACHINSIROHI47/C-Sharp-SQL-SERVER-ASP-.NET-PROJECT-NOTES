using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UseCustomControl
{
    public partial class frmIntCal : Form
    {
        public frmIntCal()
        {
            InitializeComponent();
        }

        private void frmIntCal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InterestCalculator.CalculateInterest cal = new InterestCalculator.CalculateInterest();
            cal.Principalamount = Convert.ToDouble( txtPrintcipal.Text);
            cal.Interestrate = Convert.ToDouble(txtRate.Text);
            cal.NumberOfYears = Convert.ToDouble(txtTime.Text);
            MessageBox.Show("Interest: "+Convert.ToString(cal.Calculateinterest())+"\n"+"Amount: " + Convert.ToString(cal.Calculateamount()));

        }
    }
}