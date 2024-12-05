using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reservation
{
    public partial class frmLogin2 : Form
    {
        public frmLogin2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
             String strUserId, strPassword;
            strUserId = txtUserId.Text;
            strPassword = txtPassowrd.Text;
            if (strUserId.Length == 0)
            {
                MessageBox.Show("Enter User Id");
            }
            else if (strPassword.Length == 0)
            {
                MessageBox.Show("Enter User Password");
            }
            else if (strUserId == "Admin")
            {
                if(strPassword == "rgpg007")
                {
                frmFlights obj1 = new frmFlights();
                obj1.Show();
                }
                else
                {
                     MessageBox.Show("Invalid Password");
            
                }
            }
            else
            {
                MessageBox.Show("Invalid User Id");
            }
        
        }
    }
}
