using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp16062016
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            num3 = sum(num1, num2);
            lblTotal.Text = "Total is " + num3;
          
        }
        private int sum(int var1, int var2)
        {
            int var3;
            var3 = var1 + var2;
            return var3;
        }
    }
}
