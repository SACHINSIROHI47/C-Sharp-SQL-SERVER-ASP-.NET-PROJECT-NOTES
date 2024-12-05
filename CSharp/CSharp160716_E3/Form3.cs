using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp160716_E3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (var SelectedValue in checkedListBox1.CheckedItems)
            {
                str += SelectedValue.ToString();
                str += "\n";
            }
            MessageBox.Show(str, "Choice");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (var SelectedValue in checkedListBox2.CheckedItems)
            {
                str += SelectedValue.ToString();
                str += "\n";
            }
            MessageBox.Show(str, "States");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            checkedListBox2.Items.Add("Andhra Pradesh");
            checkedListBox2.Items.Add("Madhya Pradesh");
            checkedListBox2.Items.Add("Delhi");
            checkedListBox2.Items.Add("Haryana");
            checkedListBox2.Items.Add("Uttar Pradesh");
        }
        
    }
}
