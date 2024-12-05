using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calclulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Smart Calculator");
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            num3 = num1 + num2;
            txtTotal.Text = Convert.ToString(num3);
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            num3 = num1 - num2;
            txtTotal.Text = Convert.ToString(num3);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            num3 = num1 * num2;
            txtTotal.Text = Convert.ToString(num3);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            float num1, num2, num3;
           
            num1 =(float) Convert.ToDecimal(txtNumber1.Text);
            num2 = (float)Convert.ToDecimal(txtNumber2.Text);
            num3 = num1 / num2;
            txtTotal.Text = Convert.ToString(num3);
        }
    }
}
