using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp180716_E2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*comboBox1.Items.Add("Z");
            comboBox1.Items.Add("C");
            comboBox1.Items.Add("M");
            comboBox1.Items.Add("N");
            comboBox1.Items.Add("T");
            comboBox1.Items.Add("A");
            comboBox1.Items.Add("G");*/

            comboBox1.Items.Add("9");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("5");
            comboBox1.Items.Add("7");
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
        }
    }
}
