using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp17062016
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGender_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked == true)
            {
                MessageBox.Show("Gender is " + rbMale.Text);
            }
            if (rbFemale.Checked == true)
            {
                MessageBox.Show("Gender is " + rbFemale.Text);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtUserId, "Enter User Id");
            toolTip1.SetToolTip(txtPassword, "Enter Password");
            toolTip1.SetToolTip(btnOK, "Click The Button");
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            panel1.BackColor = colorDialog1.Color;
            rbMale.BackColor = colorDialog1.Color;
            rbFemale.BackColor = colorDialog1.Color; 
        }

        private void btnTextColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblUserId.ForeColor = colorDialog1.Color;
            lblPassword.ForeColor = colorDialog1.Color;
            rbMale.ForeColor = colorDialog1.Color;
            rbFemale.ForeColor = colorDialog1.Color; 
        }

        
    }
}
