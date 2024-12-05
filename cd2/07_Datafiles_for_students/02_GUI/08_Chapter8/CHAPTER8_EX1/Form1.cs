using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chapter8_Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StaticExample s1 = new StaticExample();
            s1.ShowNumber();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StaticExample s1 = new StaticExample();
            s1.ShowNumber();

        }
    }

    public class StaticExample
    {
        static int numberOfObjects;
        static StaticExample()
        {
            numberOfObjects += 1;
        }

        public void ShowNumber()
        {
            MessageBox.Show("Number of objects created:" + numberOfObjects);
        }
    }

}