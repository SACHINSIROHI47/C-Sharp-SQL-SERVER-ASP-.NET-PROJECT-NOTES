using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chapter3_E1
{
    public partial class frmLogin : Form
    {
        int Ctr;
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string LoginName, Password;
            LoginName = txtUserName.Text;
            Password = txtPassword.Text;
            Ctr = Ctr + 1;
            if ((LoginName == "Adminuser") && (Password == "admin"))
            {
                this.Hide();
                frmStudent studentFrmObj = new frmStudent();
                studentFrmObj.Show();
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