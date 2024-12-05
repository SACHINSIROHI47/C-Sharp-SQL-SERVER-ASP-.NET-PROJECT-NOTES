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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String strUser;
            strUser = txtUserId.Text;
            strUser = strUser.ToLower();
            String strNewPassword, strConfirmedNewPassword;
            strNewPassword = txtNewPassword.Text;
            strConfirmedNewPassword = txtConfirmNewPassword.Text;
            if (txtUserId.Text == "")
            {
                MessageBox.Show("Please Enter User Name", "Error Message");
                txtUserId.Focus();
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
            else if (!(strNewPassword.Equals(strConfirmedNewPassword)))
            {
                MessageBox.Show("New Password and Confirm New Password do not match", "Error Message");
                txtUserId.Text = "";
                txtNewPassword.Text = "";
                txtConfirmNewPassword.Text = "";
                txtUserId.Focus();
            }
            else
            {
                //Duplicate User Id Check
                try
                {
                    SqlConnection con = new SqlConnection();
                    String conStr = "Data Source=RGPG-COMPUTER1;Initial Catalog=HDFCBank;User Id=sa;Password=sqlserver";
                    con.ConnectionString = conStr;
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
                        if (strUser.Equals(dr[0].ToString()))
                        {
                            MessageBox.Show("User Name already Exists", "Error Message");
                            txtUserId.Text = "";
                            txtNewPassword.Text = "";
                            txtConfirmNewPassword.Text = "";
                            txtUserId.Focus();
                            con.Close();
                        }
                    }
                    else
                    {
                        con.Close();
                        SqlConnection con2 = new SqlConnection();
                        con2.ConnectionString = "Data Source=RGPG-COMPUTER1;Initial Catalog=HDFCBank;User Id=sa;Password=sqlserver";
                        con2.Open();
                        String strQuery2 = "INSERT USERS(UserName,PASSWORD) VALUES(@uname,@pass)";
                        SqlCommand cmd2 = new SqlCommand(strQuery2, con2);

                        SqlParameter prmUser2 = new SqlParameter("@uname", strUser);
                        cmd2.Parameters.Add(prmUser2);

                        SqlParameter prmPassword = new SqlParameter("@pass", strNewPassword);
                        cmd2.Parameters.Add(prmPassword);
                        cmd2.ExecuteNonQuery();
                        con2.Close();

                        MessageBox.Show("Record has been saved", "Error Message");
                    }
                }
                catch (Exception obj)
                {
                    MessageBox.Show("Exception : " + obj.Message.ToString());
                }

            }
        }


    }

}