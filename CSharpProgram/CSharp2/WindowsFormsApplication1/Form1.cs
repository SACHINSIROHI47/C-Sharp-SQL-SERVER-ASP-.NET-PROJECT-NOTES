using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            num3 = num1 + num2;
            txtTotal.Text = Convert.ToString(num3);

        }
    }
}
