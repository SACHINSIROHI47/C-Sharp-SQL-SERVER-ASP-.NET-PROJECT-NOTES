using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//sql Connection
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace HDFC
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            String strNewPassword, strConfirmNewPassword;
            String strConfirmedNewPassword;
            strNewPassword = txtNewPassword.Text;
            strConfirmNewPassword = txtConfirmNewPassword.Text;
            if (txtUserId.Text == "")
            {
                MessageBox.Show("Please Enter User Name", "Error Message");
                txtUserId.Focus();
            }
            else if (txtOldPassword.Text == "")
            {
                MessageBox.Show("Please Enter Old Password", "Error Message");
                txtOldPassword.Focus();
            }
            else if (txtNewPassword.Text == "")
            {
                MessageBox.Show("Please Enter New Password", "Error Message");
                txtNewPassword.Focus();
            }
            else if (txtConfirmNewPassword.Text == "")
            {
                MessageBox.Show("Please Enter Confirm New Password", "Error Message");
                txtConfirmNewPassword.Focus();
            }
            else if (!(strNewPassword.Equals(strConfirmNewPassword)))
            {
                MessageBox.Show("New Password and Confirm New Password do not match", "Error Message");
                txtUserId.Text = "";
                txtOldPassword.Text = "";
                txtNewPassword.Text = "";
                txtConfirmNewPassword.Text = "";
                txtUserId.Focus();
            }
            else
            {
                String strUser, strPassword;
                strUser = txtUserId.Text;
                strUser = strUser.ToLower();
                strPassword = txtOldPassword.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=RGPG-COMPUTER1;Initial Catalog=HDFCBank;User Id=sa;Password=sqlserver";
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
                    if (strUser.Equals(dr[0].ToString()) && strPassword.Equals(dr[1].ToString()))
                    {

                        strNewPassword = txtNewPassword.Text;
                        strConfirmedNewPassword = txtConfirmNewPassword.Text;
                        if (strNewPassword.Equals(strConfirmedNewPassword))
                        {
                            strUser = txtUserId.Text;
                            strUser = strUser.ToLower();

                            SqlConnection con2 = new SqlConnection();
                            con2.ConnectionString = "Data Source=RGPG-COMPUTER1;Initial Catalog=HDFCBank;User Id=sa;Password=sqlserver";
                            con2.Open();
                            String strQuery2 = "UPDATE USERS SET PASSWORD=@pass WHERE UserName=@uname";
                            SqlCommand cmd2 = new SqlCommand(strQuery2, con2);

                            SqlParameter prmPassword = new SqlParameter("@pass", strNewPassword);
                            cmd2.Parameters.Add(prmPassword);

                            SqlParameter prmUser2 = new SqlParameter("@uname", strUser);
                            cmd2.Parameters.Add(prmUser2);

                            cmd2.ExecuteNonQuery();
                            con2.Close();
                            txtUserId.Text = "";
                            txtOldPassword.Text = "";
                            txtNewPassword.Text = "";
                            txtConfirmNewPassword.Text = "";
                            txtUserId.Focus();
                            MessageBox.Show("Password has been Changed", "Message");

                        }
                        else
                        {
                            MessageBox.Show("New Password and Confirmed New Password do not match", "Error Message");
                            txtUserId.Text = "";
                            txtOldPassword.Text = "";
                            txtNewPassword.Text = "";
                            txtConfirmNewPassword.Text = "";
                            txtUserId.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name or Password", "Error Message");
                        txtUserId.Text = "";
                        txtOldPassword.Text = "";
                        txtNewPassword.Text = "";
                        txtConfirmNewPassword.Text = "";
                        txtNewPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password", "Error Message");
                    txtUserId.Text = "";
                    txtOldPassword.Text = "";
                    txtNewPassword.Text = "";
                    txtConfirmNewPassword.Text = "";
                    txtNewPassword.Focus();
                }
                con.Close();
            }
        }
    }
}
