using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckedListBoxProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Maharashtra");
            checkedListBox1.Items.Add("Punjab");
            checkedListBox1.Items.Add("Madhya Pradesh");
            checkedListBox1.Items.Add("Gujrat");
            checkedListBox1.Items.Add("Karnataka");
            checkedListBox1.Items.Add("Goa");
            checkedListBox1.Items.Add("Jammu Kashmir");
            checkedListBox1.Items.Add("Haryana");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

          for (int i=0; i< checkedListBox1.CheckedItems.Count;i++)
         {
            MessageBox.Show(checkedListBox1.CheckedItems[i].ToString(),"Selected Item");
         }
        }
    }
}
