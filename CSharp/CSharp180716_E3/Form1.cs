using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp180716_E3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("C#");
            comboBox1.Items.Add("Java");
            comboBox1.Items.Add("SQL Server");
            comboBox1.Items.Add("Adobe Photshop");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Please select the item");
            }
            else
            {
                MessageBox.Show(comboBox1.SelectedItem.ToString());
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Items.Count.ToString());
        }
    }
}
