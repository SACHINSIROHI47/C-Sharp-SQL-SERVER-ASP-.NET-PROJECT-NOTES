using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//to make sql connection
using System.Data.Sql;
using System.Data.SqlClient;


namespace HDFC
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //Start of btnOK_Click
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text.Length == 0)
            {
                MessageBox.Show("Enter User Id");
                txtUserId.Focus();
            }
            else if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Enter Password");
                txtUserId.Focus();
            }
            else
            {
                String strUser, strPassword;
                strUser = txtUserId.Text;
                strUser = strUser.ToLower();
                strPassword = txtPassword.Text;
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
                        frmMenu obj = new frmMenu();
                        obj.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name or Password", "Error Message");
                        txtUserId.Text = "";
                        txtPassword.Text = "";
                        txtUserId.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password", "Error Message");
                    txtUserId.Text = "";
                    txtPassword.Text = "";
                    txtUserId.Focus();
                }
                con.Close();
            }
            //End of btnOK_Click
        }
    }
}
