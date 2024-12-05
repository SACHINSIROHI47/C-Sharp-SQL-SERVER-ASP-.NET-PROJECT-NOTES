using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chapter3_AC1
{
    public partial class Form1 : Form
    {
        int Ctr;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            string LoginName, Password;
            LoginName = txtUserName.Text;
            Password = txtPassword.Text;
            Ctr = Ctr + 1;
            if ((LoginName == "sa") && (Password == "callcenter"))
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Welcome to Diaz Telecommunications";
                Ctr = 0;
            }
            else
                if (Ctr < 3)
                {
                    lblMessage.Visible = true;
                    lblMessage.Text = "Incorrect User Name or Password-Please Try again";
                    txtUserName.Focus();
                }
                else
                {
                    MessageBox.Show("Unauthorized Access. Aborting...");
                    Close();
                }

        }
    }
}