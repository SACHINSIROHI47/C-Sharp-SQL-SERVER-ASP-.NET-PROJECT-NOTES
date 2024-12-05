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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                int intNum;
                intNum = Convert.ToInt32(txtNumber.Text);
                intNum = intNum * 2;
                MessageBox.Show("The Product is " + intNum);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
