using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace submission_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Smart Calculator");
        }

     


           private void btn1Sum_Click(object sender, EventArgs e)
           {
               int num1, num2, num3;
               num1 = Convert.ToInt32(txtnumber1.Text);
               num2 = Convert.ToInt32(txtnumber2.Text);
               num3 = num1 + num2;
               txttotal.Text = Convert.ToString(num3);
           }

           private void btn2Subtract_Click(object sender, EventArgs e)
           {
               int num1, num2, num3;
               num1 = Convert.ToInt32(txtnumber1.Text);
               num2 = Convert.ToInt32(txtnumber2.Text);
               num3 = num1 - num2;
               txttotal.Text = Convert.ToString(num3);
           }

           private void btn3Multiply_Click(object sender, EventArgs e)
           {
               int num1, num2, num3;
               num1 = Convert.ToInt32(txtnumber1.Text);
               num2 = Convert.ToInt32(txtnumber2.Text);
               num3 = num1 * num2;
               txttotal.Text = Convert.ToString(num3);
           }

           private void btn4Divide_Click(object sender, EventArgs e)
           {
               int num1, num2, num3;
               num1 = Convert.ToInt32(txtnumber1.Text);
               num2 = Convert.ToInt32(txtnumber2.Text);
               num3 = num1 / num2;
               txttotal.Text = Convert.ToString(num3);
           }

           private void btn5Modulus_Click(object sender, EventArgs e)
           {
               int num1, num2, num3;
               num1 = Convert.ToInt32(txtnumber1.Text);
               num2 = Convert.ToInt32(txtnumber2.Text);
               num3 = num1 / num2;
               txttotal.Text = Convert.ToString(num3);
           

           }

          

        


        }
    }

