using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BANKING
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Please Enter User Name", "Error Message");
                txtUser.Focus();
            }
            else if(txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Error Message");
                txtPassword.Focus();
            }
            else
            {
                String strUser, strPassword;
                strUser=txtUser.Text;
                strUser=strUser.ToLower();
                strPassword=txtPassword.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=INDIA;Initial Catalog=SBIBank;User Id=sa;Password=rgpg007";
                con.Open();
                String strQuery = "SELECT * FROM USERS WHERE UserName=@uname";
                SqlCommand cmd = new SqlCommand(strQuery, con);
                SqlParameter prmUser = new SqlParameter("@uname",strUser);
                cmd.Parameters.Add(prmUser);
                //int num=0;
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows.ToString().Equals("True"))
                 {
                     if (strUser.Equals(dr[0].ToString()) && strPassword.Equals(dr[1].ToString()))
                     {
                         frmMenu obj = new frmMenu();
                         obj.Show();
                         this.Hide();
                         return;
                     }
                     else
                     {
                         MessageBox.Show("Invalid User Name or Password", "Error Message");
                         txtUser.Text = "";
                         txtPassword.Text = "";
                         txtUser.Focus();
                     }
                 }
                 else
                 {
                     MessageBox.Show("Invalid User Name or Password", "Error Message");
                     txtUser.Text = "";
                     txtPassword.Text = "";
                     txtUser.Focus();
                 }
                con.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

            frmChangePassword obj = new frmChangePassword();
            obj.Show();                       
        }

        private void cmdCreateUser_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Please Enter User Name", "Error Message");
                txtUser.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Error Message");
                txtPassword.Focus();
            }
            else
            {
                String strUser, strPassword;
                strUser = txtUser.Text;
                strUser = strUser.ToLower();
                strPassword = txtPassword.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=INDIA;Initial Catalog=SBIBank;User Id=sa;Password=rgpg007";
                con.Open();
                String strQuery = "SELECT * FROM USERS WHERE UserName=@uname";
                SqlCommand cmd = new SqlCommand(strQuery, con);
                SqlParameter prmUser = new SqlParameter("@uname", strUser);
                cmd.Parameters.Add(prmUser);
                //int num=0;
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows.ToString().Equals("True"))
                {
                    if (strUser.Equals("admin") && strPassword.Equals(dr[1].ToString()))
                    {
                        frmUsers obj = new frmUsers();
                        obj.Show();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name or Password, Only Administrator can create New User", "Error Message");
                        txtUser.Text = "";
                        txtPassword.Text = "";
                        txtUser.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password", "Error Message");
                    txtUser.Text = "";
                    txtPassword.Text = "";
                    txtUser.Focus();
                }
                con.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}