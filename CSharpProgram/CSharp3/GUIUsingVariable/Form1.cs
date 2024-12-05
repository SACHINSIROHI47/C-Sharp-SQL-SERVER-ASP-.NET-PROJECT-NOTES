using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUIUsingVariable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char grade = 'B';
            String name = "Bill Gates";
            int age = 26;
            float fee = 5000.45F;
            double total_fee = 85768.765;
            bool selection = true;

           MessageBox.Show("Displaying Variables values");
           MessageBox.Show("----------------");
           MessageBox.Show("Grade is "+ grade);
           MessageBox.Show("Name is " + name);
           MessageBox.Show("Age is " + age);
           MessageBox.Show("Fee is " + fee);
           MessageBox.Show("Total Fee is " + total_fee);
           MessageBox.Show("Selection is " + selection);
            MessageBox.Show("----------------");
            MessageBox.Show("Another Methaod");
            MessageBox.Show("----------------");
            MessageBox.Show("Age is");
            MessageBox.Show(age.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = "Bill Gates";
            int age = 26;
            MessageBox.Show("Name is " + name + "\nAge is " + age);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String address = "22/45 Patpad Ganj New Delhi";
            MessageBox.Show(address);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool xx;
            xx = true;
            MessageBox.Show(xx.ToString());
        }


    }
}
