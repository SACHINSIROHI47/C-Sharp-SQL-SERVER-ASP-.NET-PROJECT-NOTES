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
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }OPTION2 VARCHAR(10);
            }
        }
        //Account Form Starting
        private void frmAccount_Load(object sender, EventArgs e)
        {
            cmbAccountType.Items.Add("Saving");
            cmbAccountType.Items.Add("Current");
            cmbAccountType.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbState.Items.Add("Delhi");            
            cmbState.Items.Add("Maharashtra");
            cmbState.Items.Add("Bihar");
            cmbState.Items.Add("Uttar Pradesh");
            cmbState.Items.Add("Uttarkhand");

         //Add Account Numner in Combobbox from SQL Server
            try
            {
                String conStr = "Data Source=RGPG-COMPUTER1;Initial Catalog=HDFCBank;User Id=sa;Password=sqlserver";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conStr;
                con.Open();

                String str2 = "SELECT ACNO FROM ACCOUNTS";
                SqlCommand cmd2 = new SqlCommand(str2, con);
                cmd2.CommandType = CommandType.Text;

                SqlDataReader reader;
                reader = cmd2.ExecuteReader();
                cmbAccountNumber.Items.Clear();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        cmbAccountNumber.Items.Add(Convert.ToString(reader["QUESNO"]));
                    }
                }
                else
                {
                    MessageBox.Show("Record did not Find", "Error Message");
                }
                con.Close();

            }
            catch (Exception obj)
            {       
                 MessageBox.Show("Exception : " + obj.Message.ToString());
            }
            
        }        //Account Form Ending

        //State Combox Starting
        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCity.Items.Clear();            
            if (cmbState.Text == "Delhi")
            {
                cmbCity.Items.Add("North Delhi");
                cmbCity.Items.Add("South Delhi");
                cmbCity.Items.Add("East Delhi");
                cmbCity.Items.Add("West Delhi");
            }
            else if (cmbState.Text == "Maharashtra")
            {
                cmbCity.Items.Add("Mumbai");
                cmbCity.Items.Add("Pune");
                cmbCity.Items.Add("Aurangabad");
                cmbCity.Items.Add("Thane");
            }
            else if (cmbState.Text == "Bihar")
            {
                cmbCity.Items.Add("Patna");
                cmbCity.Items.Add("Ranchi");
            }
            else if (cmbState.Text == "Uttar Pradesh")
            {
                cmbCity.Items.Add("Meerut");
                cmbCity.Items.Add("Agra");
                cmbCity.Items.Add("Noida");
                cmbCity.Items.Add("Kanpur");
                cmbCity.Items.Add("Luckhnow");
            }
            else if (cmbState.Text == "Uttarkhand")
            {
                cmbCity.Items.Add("Dehradun");
                cmbCity.Items.Add("Haridwar");
                cmbCity.Items.Add("Nainital");
                cmbCity.Items.Add("Pauri");
            }
            else
            {

            }
            cmbCity.Sorted = true;
        }
        //State Combox Ending

        //New Button Starting
        private void btnNew_Click(object sender, EventArgs e)
        {
            String conStr = "Data Source=RGPG-COMPUTER1;Initial Catalog=HDFCBank;User Id=sa;Password=sqlserver";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conStr;
            con.Open();
            String str = "SELECT ACNO FROM ACCOUNTS  ORDER BY ACNO ASC";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            String strACNO, strACNOPart;
            int intACNO;
            strACNO = "";
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    strACNO = Convert.ToString(reader["ACNO"]);
                }
                strACNOPart = strACNO.Substring(1, 5);
                intACNO = Convert.ToInt32(strACNOPart);
                intACNO++;
                strACNOPart = Convert.ToString(intACNO);
                if ((intACNO >= 1) && (intACNO <= 9))
                {
                    strACNO = "A0000" + strACNOPart;
                }
                else if ((intACNO >= 10) && (intACNO <= 99))
                {
                    strACNO = "A000" + strACNOPart;
                }
                else if ((intACNO >= 100) && (intACNO <= 999))
                {
                    strACNO = "A00" + strACNOPart;
                }
                else if ((intACNO >= 1000) && (intACNO <= 9999))
                {
                    strACNO = "A0" + strACNOPart;
                }
                else
                {
                    strACNO = "A" + strACNOPart;
                }
                cmbAccountNumber.Text = strACNO;
            }
            else
            {
                cmbAccountNumber.Text = "A00001";
                MessageBox.Show("Record did not Find", "Message");
            }

            con.Close();
            cmbAccountType.SelectedIndex = -1;            
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            cmbState.SelectedIndex = -1;
            cmbCity.Text = "";
            dtpDateOfBirth.Text = "";
            dtpOpemingDate.Text = "";
            txtBalance.Text = "";
            txtPhoneNumber.Text = "";
            pictureBox1.ImageLocation = null;
        }
        //New Button Ending

        //Find Button Starting
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cmbAccountNumber.Text == "")
            {
                MessageBox.Show("Please Enter Account Number", "Error Message");
                cmbAccountNumber.Focus();
            }
            else
            {
                String conStr = "Data Source=RGPG-COMPUTER1;Initial Catalog=HDFCBank;User Id=sa;Password=sqlserver";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conStr;
                con.Open();
                String str = "SELECT * FROM ACCOUNTS WHERE ACNO=@acno";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.Text;

                SqlParameter spacno;
                spacno = cmd.Parameters.Add("@acno", SqlDbType.Char, 6);
                spacno.Value = cmbAccountNumber.Text;


                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows == true)
                {
                    cmbAccountType.Text = Convert.ToString(reader["ACCOUNT_TYPE"]);                    
                    txtFirstName.Text = Convert.ToString(reader["FIRST_NAME"]);
                    txtLastName.Text = Convert.ToString(reader["LAST_NAME"]);
                    txtAddress.Text = Convert.ToString(reader["ADDRESS"]);
                    cmbState.Text = Convert.ToString(reader["STATE"]);
                    cmbCity.Text = Convert.ToString(reader["CITY"]);
                    txtBalance.Text = Convert.ToString(reader["BALANCE"]);
                    txtPhoneNumber.Text = Convert.ToString(reader["PHONE_NO"]);
                    dtpDateOfBirth.Text = Convert.ToString(reader["DATE_OF_BIRTH"]);
                    dtpOpemingDate.Text = Convert.ToString(reader["OPENING_DATE"]);
                    pictureBox1.ImageLocation = Convert.ToString(reader["AC_IMAGE"]);

                }
                else
                {
                    MessageBox.Show("Record did not Find", "Error Message");
                }
            }
        }
        //Find Button Ending

        //Modify Button Starting
        private void btnModify_Click(object sender, EventArgs e)
        {
            //To Check blank value
            if (cmbAccountNumber.Text == "")
            {
                MessageBox.Show("Please Enter Account Number", "Error Message");
                cmbAccountNumber.Focus();
            }
            else if (cmbAccountType.Text == "")
            {
                MessageBox.Show("Please Select Account Type", "Error Message");
                cmbAccountType.Focus();
            }
            else if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please Enter First Name", "Error Message");
                txtFirstName.Focus();
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("Please Enter Last Name", "Error Message");
                txtLastName.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Address", "Error Message");
                txtAddress.Focus();
            }
            else if (cmbState.Text == "")
            {
                MessageBox.Show("Please Select State", "Error Message");
                cmbState.Focus();
            }
            else if (cmbCity.Text == "")
            {
                MessageBox.Show("Please Enter City", "Error Message");
                cmbCity.Focus();
            }
            else if (dtpDateOfBirth.Text == "")
            {
                MessageBox.Show("Please Enter Date of Birth", "Error Message");
                dtpDateOfBirth.Focus();
            }
            else if (dtpDateOfBirth.Text == "")
            {
                MessageBox.Show("Please Enter Opening Date", "Error Message");
                dtpDateOfBirth.Focus();
            }
            else if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Please Enter Phone Number", "Error Message");
                txtPhoneNumber.Focus();
            }
            else if (txtBalance.Text == "")
            {
                MessageBox.Show("Please Enter Balance", "Error Message");
                txtBalance.Focus();
            }
            else if (pictureBox1.ImageLocation == null)
            {
                MessageBox.Show("Please Select the Image", "Error Message");
                btnSelectPicture.Focus();
            }
            else
            {
                String strFirstName, strLastName, strBalance, strPhoneno, strPart;

                int ctr;

                strFirstName = txtFirstName.Text;
                for (ctr = 0; ctr < strFirstName.Length; ctr++)
                {
                    strPart = strFirstName.Substring(ctr, 1);
                    if (!char.IsLetterOrDigit(Convert.ToChar(strPart)) && Convert.ToChar(strPart) != ' ' && Convert.ToChar(strPart) != '.')
                    {
                        MessageBox.Show("First Name can contains Alphabets, Digits [0-9], space and Dot only", "Error Message");
                        return;
                    }
                }
                strLastName = txtLastName.Text;
                for (ctr = 0; ctr < strLastName.Length; ctr++)
                {
                    strPart = strLastName.Substring(ctr, 1);
                    if (!char.IsLetterOrDigit(Convert.ToChar(strPart)) && Convert.ToChar(strPart) != ' ' && Convert.ToChar(strPart) != '.')
                    {
                        MessageBox.Show("Last Name can contains Alphabets, Digits [0-9], space and Dot only", "Error Message");
                        return;
                    }
                }

                strPhoneno = txtPhoneNumber.Text;
                for (ctr = 0; ctr < strPhoneno.Length; ctr++)
                {
                    strPart = strPhoneno.Substring(ctr, 1);
                    if (!char.IsDigit(Convert.ToChar(strPart)) && Convert.ToChar(strPart) != '-')
                    {
                        MessageBox.Show("Phone Number can contains Digits [0-9] and Hyphen only", "Error Message");
                        return;
                    }
                }

                strBalance = txtBalance.Text;
                for (ctr = 0; ctr < strBalance.Length; ctr++)
                {
                    strPart = strBalance.Substring(ctr, 1);
                    if (!char.IsDigit(Convert.ToChar(strPart)) && Convert.ToChar(strPart) != '.')
                    {
                        MessageBox.Show("Balance can contains Digits [0-9] and Dot only", "Error Message");
                        return;
                    }
                }


                double dbBalance;
                dbBalance = Convert.ToDouble(txtBalance.Text);
                DateTime dtOpDate, dtDateofBirth, dtCurrentDate;
                dtDateofBirth = Convert.ToDateTime(dtpDateOfBirth.Text);
                 dtOpDate  = Convert.ToDateTime(dtpOpemingDate.Text);
                dtCurrentDate = DateTime.Now;

                if (dbBalance <= 0)
                {
                    MessageBox.Show("Balance should be greater than Zero", "Error Message");
                    txtBalance.Focus();
                }
                //else if (dtDateofBirth.DayOfYear > dtCurrentDate.DayOfYear)
                else if (DateTime.Compare(dtDateofBirth, dtCurrentDate) > 0)
                {
                    MessageBox.Show("Date of Birth cannot be greater than Current Date", "Error Message");
                    dtpDateOfBirth.Focus();
                }
                else if (DateTime.Compare(dtOpDate, dtCurrentDate) > 0)
                {
                    MessageBox.Show("Opening Date cannot be greater than Current Date", "Error Message");
                    dtpDateOfBirth.Focus();
                }
                else
                {
                    try
                    {
                    String conStr = "Data Source=RGPG-COMPUTER1;Initial Catalog=HDFCBank;User Id=sa;Password=sqlserver";
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = conStr;
                    con.Open();
                    String str = "UPDATE ACCOUNTS SET ACCOUNT_TYPE=@actype,FIRST_NAME=@first_name,LAST_NAME=@last_name,ADDRESS=@address,STATE=@state,CITY=@city,DATE_OF_BIRTH=@dateofbirth,OPENING_DATE=@opdate,BALANCE=@balance,PHONE_NO=@phoneno,AC_IMAGE=@acimage WHERE ACNO=@acno";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.CommandType = CommandType.Text;

                    SqlParameter spacno;
                    spacno = cmd.Parameters.Add("@acno", SqlDbType.Char, 6);
                    spacno.Value = cmbAccountNumber.Text;

                    SqlParameter spactype;
                    spactype = cmd.Parameters.Add("@actype", SqlDbType.VarChar, 10);
                    spactype.Value = cmbAccountType.Text;

                    SqlParameter spfirst_name;
                    spfirst_name = cmd.Parameters.Add("@first_name", SqlDbType.VarChar, 30);
                    spfirst_name.Value = txtFirstName.Text;

                    SqlParameter splast_name;
                    splast_name = cmd.Parameters.Add("@last_name", SqlDbType.VarChar, 30);
                    splast_name.Value = txtLastName.Text;

                    SqlParameter spaddress;
                    spaddress = cmd.Parameters.Add("@address", SqlDbType.VarChar, 50);
                    spaddress.Value = txtAddress.Text;

                    SqlParameter spstate;
                    spstate = cmd.Parameters.Add("@state", SqlDbType.VarChar, 40);
                    spstate.Value = cmbState.Text;

                    SqlParameter spcity;
                    spcity = cmd.Parameters.Add("@city", SqlDbType.VarChar, 40);
                    spcity.Value = cmbCity.Text;

                    SqlParameter spdateofbirth;
                    spdateofbirth = cmd.Parameters.Add("@dateofbirth", SqlDbType.DateTime);
                    spdateofbirth.Value = dtDateofBirth;

                    SqlParameter spopdate;
                    spopdate = cmd.Parameters.Add("@opdate", SqlDbType.DateTime);
                    spopdate.Value = dtOpDate;

                    SqlParameter spPhoneNumber;
                    spPhoneNumber = cmd.Parameters.Add("@phoneno", SqlDbType.VarChar, 15);
                    spPhoneNumber.Value = txtPhoneNumber.Text;

                    SqlParameter spbalance;
                    spbalance = cmd.Parameters.Add("@balance", SqlDbType.Money);
                    spbalance.Value = dbBalance;

                    SqlParameter spacimage;
                    spacimage = cmd.Parameters.Add("@acimage", SqlDbType.VarChar, 100);
                    spacimage.Value = pictureBox1.ImageLocation;

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been Udated", "Message");
                    }
                    catch (Exception obj)
                    {
                        MessageBox.Show("Exception : " + obj.Message.ToString());
                    }
                }
            }
        }
        //Modify Button Ending

        //Delete Button Starting
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (cmbAccountNumber.Text == "")
            {
                MessageBox.Show("Please Enter Account Number", "Error Message");
                cmbAccountNumber.Focus();
            }
            else
            {
                try
                {
                String conStr = "Data Source=RGPG-COMPUTER1;Initial Catalog=HDFCBank;User Id=sa;Password=sqlserver";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conStr;
                con.Open();
                String str = "DELETE ACCOUNTS WHERE ACNO=@acno";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.Text;


                SqlParameter spacno;
                spacno = cmd.Parameters.Add("@acno", SqlDbType.Char, 6);
                spacno.Value = cmbAccountNumber.Text;
                cmd.ExecuteNonQuery();

                cmbAccountNumber.Text = "";
                cmbAccountType.SelectedIndex = -1;
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtAddress.Text = "";
                cmbState.Text = "";
                cmbCity.Text = "";
                dtpDateOfBirth.Text = "";
                dtpOpemingDate.Text = "";
                txtBalance.Text = "";
                txtPhoneNumber.Text = "";
                pictureBox1.ImageLocation = null;              

                String conStr3 = "Data Source=RGPG-COMPUTER1;Initial Catalog=HDFCBank;User Id=sa;Password=sqlserver";
                SqlConnection con3 = new SqlConnection();
                con3.ConnectionString = conStr3;
                con3.Open();
                String str3 = "SELECT ACNO FROM ACCOUNTS";
                SqlCommand cmd3 = new SqlCommand(str3, con3);
                cmd3.CommandType = CommandType.Text;

                SqlDataReader reader3;
                reader3 = cmd3.ExecuteReader();
                cmbAccountNumber.Items.Clear();
                while (reader3.Read())
                {
                    cmbAccountNumber.Items.Add(Convert.ToString(reader3["ACNO"]));
                }
                con.Close();
                con3.Close();
                }
                catch (Exception obj)
                {
                    MessageBox.Show("Exception : " + obj.Message.ToString());
                }
              }
            }
        //Delete Button Ending
        }

        
   
}
