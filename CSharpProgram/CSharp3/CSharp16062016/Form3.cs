using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp16062016
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnOK.Size = new System.Drawing.Size(200, 100);
            lblPassword.Text = "User Password";
            this.btnOK.Location = new System.Drawing.Point(215, 271);
            lblUserName.Visible = true;
            txtUserName.Visible = true;
            lblAddress.Visible = true;
            txtAddress.Visible = true;

            lblUserId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(15)))), ((int)(((byte)(92)))));

            lblPassword.ForeColor = System.Drawing.Color.Red;
            lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(180)))), ((int)(((byte)(78)))));

            txtUseriD.Enabled = true;
            btnClear.Enabled = true;
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUseriD.Text = "";
            txtPassword.Text = "";
            
        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtAccountNumber.Text.Length == 0)
            {
                txtAccountNumber.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                txtAccountNumber.BackColor = System.Drawing.Color.Plum;
            }
        }

        private void btnMove_MouseMove(object sender, EventArgs e)
        {
            btnMove.BackColor = System.Drawing.Color.Pink;
            MessageBox.Show("Moving Mouse");
        }      
    }
}
