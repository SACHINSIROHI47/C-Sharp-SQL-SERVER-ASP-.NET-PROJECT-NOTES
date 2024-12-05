using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales
{
    public partial class Form1 : Form
    {
        Boolean flag=true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mr./Miss " + textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String str1;
            str1 = textBox1.Text;
            if (str1.Length == 0)
            {
                textBox1.BackColor = System.Drawing.Color.Red;
              
            }
            else
            {
                textBox1.BackColor = System.Drawing.Color.Azure;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (flag == true)
            {
                textBox2.BackColor = System.Drawing.Color.Azure;
                button1.BackColor = System.Drawing.Color.Red;
                flag = false;
            }
            else
            {
                textBox2.BackColor = System.Drawing.Color.Pink;
                button1.BackColor = System.Drawing.Color.Green;
                flag = true;
            }
        }
    }
}
