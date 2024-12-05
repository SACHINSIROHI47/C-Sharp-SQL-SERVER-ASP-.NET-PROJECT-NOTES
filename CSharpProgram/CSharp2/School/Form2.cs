using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace School
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Welcome " + txtName.Text);
        }

        private void btnStyle_Click(object sender, EventArgs e)
        {
             btnShow.BackColor = System.Drawing.Color.Blue;
            label1.BackColor=System.Drawing.Color.DarkGreen;
            txtName.BackColor=System.Drawing.Color.LightCoral;
            btnStyle.BackColor=System.Drawing.Color.Plum;
            label1.Location = new System.Drawing.Point(140, 366);
            this.label1.Size = new System.Drawing.Size(234, 113);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label2 Hi");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("TextBox Hi");
        }

       

       
    }
}
