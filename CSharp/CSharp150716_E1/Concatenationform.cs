using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp150716_E1
{
    public partial class Concatenationform : Form
    {
        public Concatenationform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String x;
            x = "Welcome ";
            x = x + txtUserFirstName.Text + " ";
            x = x + txtUserLastName.Text;
            MessageBox.Show(x, "Displaying Message");
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(230)))), ((int)(((byte)(36)))));
            this.label2.BackColor = System.Drawing.Color.Azure;
        }
    }
}
