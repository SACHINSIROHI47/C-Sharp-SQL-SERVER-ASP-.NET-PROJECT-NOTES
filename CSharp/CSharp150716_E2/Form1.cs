using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp150716_E2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String x;
            x = txtText.Text;
            int y;

            y = x.Length;

            String lengthDisplay;

            lengthDisplay = "Length:= " + y;
            MessageBox.Show(lengthDisplay, "Displaying Length");
        }
    }
}
