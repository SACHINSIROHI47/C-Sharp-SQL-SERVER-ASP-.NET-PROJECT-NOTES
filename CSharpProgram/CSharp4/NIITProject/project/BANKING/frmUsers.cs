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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String strUser;
            strUser = txtUser.Text;
            strUser = strUser.ToLower();
            String strNewPassword, strConfirmedNewPassword;
           strNewPassword = txtNewPassword.Text;
            strConfirmedNewPassword = txtConfirmNewPassword.Text;
            if (txtUser.Text == "")
            {
                MessageBox.Show("Please Enter User Name", "Error Message");
                txtUser.Focus();
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
                txtUser.Text = "";
                txtNewPassword.Text = "";
                txtConfirmNewPassword.Text = "";
                txtUser.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=GLAXY-VAIO;Initial Catalog=SBIBank;User Id=sa;Password=NiitCity05";
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
                        txtUser.Text = "";
                        txtNewPassword.Text = "";
                        txtConfirmNewPassword.Text = "";
                        txtUser.Focus();
                        con.Close();                    
                    }                    
                }
                else
                {                   
                    con.Close();
                    SqlConnection con2 = new SqlConnection();
                    con2.ConnectionString = "Data Source=GLAXY-VAIO;Initial Catalog=SBIBank;User Id=sa;Password=NiitCity05";
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            String strUser;
            strUser = txtUser.Text;
            strUser = strUser.ToLower();
            if (txtUser.Text == "")
            {
                MessageBox.Show("Please Enter User Name", "Error Message");
                txtUser.Focus();
            }
            else if(strUser.Equals("admin"))
            {
                MessageBox.Show("Admin cannot be Deleted", "Error Message");
                txtUser.Text="";
                txtUser.Focus();
            }
            else
            {                           
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=GLAXY-VAIO;Initial Catalog=SBIBank;User Id=sa;Password=NiitCity05";
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
                        con.Close();
                        SqlConnection con2 = new SqlConnection();
                        con2.ConnectionString = "Data Source=GLAXY-VAIO;Initial Catalog=SBIBank;User Id=sa;Password=NiitCity05";
                        con2.Open();
                        String strQuery2 = "DELETE USERS WHERE UserName=@uname";
                        SqlCommand cmd2 = new SqlCommand(strQuery2, con2);

                        SqlParameter prmUser2 = new SqlParameter("@uname", strUser);
                        cmd2.Parameters.Add(prmUser2);
                        cmd2.ExecuteNonQuery();
                        con2.Close();
                        txtUser.Text = "";
                        MessageBox.Show("Record has been deleted", "Error Message");
                                  
                                    
                }
                else
                {
                    con.Close();
                    txtUser.Text = "";
                     MessageBox.Show("User Name does not Exists", "Error Message");
                }

            }
        }
    }
     
}