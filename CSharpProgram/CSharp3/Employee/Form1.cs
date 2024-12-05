using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int intAge;
            intAge = Convert.ToInt32(txtAge.Text);
            if(intAge<=30)
            {
                MessageBox.Show("Juniour");
               
            }
            else
            {
                MessageBox.Show("Seniour");
            }

        }

        private void btnCheckName_Click(object sender, EventArgs e)
        {
            String strName;
            strName = txtName.Text;

            if (strName == "Raj")
            {
                MessageBox.Show("Welcome Raj");
            }
            else
            {
                MessageBox.Show("Invalid Name");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            x = 2;
            if (x > 3)
            {
                MessageBox.Show(" X > 3 ");
            }
            else
            {
                MessageBox.Show(" X < 3 ");
            }

        }
    }
}
