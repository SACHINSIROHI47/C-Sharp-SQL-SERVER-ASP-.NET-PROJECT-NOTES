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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            x = 5;
            if (x > 3)
            {
                MessageBox.Show(" X > 3 ");
            }
            else if (x == 3)
            {
                MessageBox.Show(" X == 3 ");
            }
            else
            {
                MessageBox.Show(" X < 5 ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; )
            {
                MessageBox.Show("Hello");
            }
        }
    }
}
