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
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            String strUser;
            strUser = txtUserId.Text;
            strUser = strUser.ToLower();
            if (txtUserId.Text == "")
            {
                MessageBox.Show("Please Enter User Name", "Error Message");
                txtUserId.Focus();
            }
            else if (strUser.Equals("admin"))
            {
                MessageBox.Show("Admin cannot be Deleted", "Error Message");
                txtUserId.Text = "";
                txtUserId.Focus();
            }
            else
            {
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
                    con.Close();
                    SqlConnection con2 = new SqlConnection();
                    con2.ConnectionString = "Data Source=RGPG-COMPUTER1;Initial Catalog=HDFCBank;User Id=sa;Password=sqlserver";
                    con2.Open();
                    String strQuery2 = "DELETE USERS WHERE UserName=@uname";
                    SqlCommand cmd2 = new SqlCommand(strQuery2, con2);

                    SqlParameter prmUser2 = new SqlParameter("@uname", strUser);
                    cmd2.Parameters.Add(prmUser2);
                    cmd2.ExecuteNonQuery();
                    con2.Close();
                    txtUserId.Text = "";
                    MessageBox.Show("Record has been deleted", "Error Message");


                }
                else
                {
                    con.Close();
                    txtUserId.Text = "";
                    MessageBox.Show("User Name does not Exists", "Error Message");
                }

            }
        }
        }
    }

