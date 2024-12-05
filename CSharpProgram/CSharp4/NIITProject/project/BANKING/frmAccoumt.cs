using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace BANKING
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            String conStr = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conStr;
            con.Open();
            String str = "SELECT ACNO FROM ACCOUNTS  ORDER BY ACNO ASC";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            String strACNO,strACNOPart;
            int intACNO;
            strACNO = "";
            if (reader.HasRows == true)
            {
                while (reader.Read())
               {
                   strACNO=Convert.ToString(reader["ACNO"]);
               }
                strACNOPart = strACNO.Substring(1,5);
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
                cmbACNO.Text = strACNO;
            }
            else
            {
                cmbACNO.Text = "A00001";
                MessageBox.Show("Record did not Find", "Message");
            }

            con.Close();
            cmbAccountType.SelectedIndex = -1; 
            txtCreditLimit.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtBalance.Text = "";
            txtPhoneNumber.Text= "";
            txtDateofBirth.Text = "";
            txtOpeningDate.Text = "";
            pictureBox1.ImageLocation = "";

            cmdSave.Enabled = true;
            cmdCancel.Enabled = true;
            cmbACNO.Enabled = false;           
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (cmbACNO.Text == "")
            {
                MessageBox.Show("Please Enter Account Number", "Error Message");
                cmbACNO.Focus();
            }
            else if (cmbAccountType.Text == "")
            {
                MessageBox.Show("Please Select Account Type", "Error Message");
                cmbAccountType.Focus();
            }
            else if (txtCreditLimit.Text == "")
            {
                MessageBox.Show("Please Enter Credit Limit", "Error Message");
                txtCreditLimit.Focus();
            }             
            else if (txtName.Text == "")
            {
                MessageBox.Show("Please Enter Name", "Error Message");
                txtName.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Address", "Error Message");
                txtAddress.Focus();
            }
            else if (txtBalance.Text == "")
            {
                MessageBox.Show("Please Enter Balance", "Error Message");
                txtBalance.Focus();
            }
            else if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Please Enter Phone Number", "Error Message");
                txtPhoneNumber.Focus();
            }
            else if (txtDateofBirth.Text == "")
            {
                MessageBox.Show("Please Enter Date of Birth", "Error Message");
                txtDateofBirth.Focus();
            }
            else if (txtOpeningDate.Text == "")
            {
                MessageBox.Show("Please Enter Opening Date", "Error Message");
                txtOpeningDate.Focus();
            }
            else if (pictureBox1.ImageLocation.Length==0)
            {
                MessageBox.Show("Please Select the Image", "Error Message");
                btnBrowse.Focus();
            }
            else
            {
                String strName,strCreditLimit, strBalance, strPhoneno, strPart;
                int ctr;

                strCreditLimit = txtCreditLimit.Text;
                for (ctr = 0; ctr < strCreditLimit.Length; ctr++)
                {
                    strPart = strCreditLimit.Substring(ctr, 1);
                    if (!char.IsDigit(Convert.ToChar(strPart)) && Convert.ToChar(strPart) != '.')
                    {
                        MessageBox.Show("Credit Limit can contains Digits [0-9] and Dot only", "Error Message");
                        return;
                    }
                }

                strName = txtName.Text;
                for (ctr = 0; ctr < strName.Length; ctr++)
                {
                    strPart = strName.Substring(ctr, 1);
                    if (!char.IsLetterOrDigit(Convert.ToChar(strPart)) && Convert.ToChar(strPart) != ' ' && Convert.ToChar(strPart) != '.')
                    {
                        MessageBox.Show("Name can contains Alphabets, Digits [0-9], space and Dot only", "Error Message");
                        return;
                    }
                }

                strBalance = txtBalance.Text;
                for(ctr=0;ctr<strBalance.Length;ctr++)
                {
                    strPart=strBalance.Substring(ctr,1);
                   if (!char.IsDigit(Convert.ToChar(strPart)) && Convert.ToChar(strPart) != '.')
                    {
                        MessageBox.Show("Balance can contains Digits [0-9] and Dot only", "Error Message");
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

                double dbBalance, dbCreditLimit;
                dbBalance = Convert.ToDouble(txtBalance.Text);
                dbCreditLimit = Convert.ToDouble(txtCreditLimit.Text);
                DateTime dtOpDate,dtDateofBirth, dtCurrentDate;
                dtOpDate = Convert.ToDateTime(txtOpeningDate.Text);
                dtDateofBirth = Convert.ToDateTime(txtDateofBirth.Text);
                dtCurrentDate = DateTime.Now;
                if (dbCreditLimit < 0)
                {
                    MessageBox.Show("Credit Limit should be greater than Zero", "Error Message");
                    txtCreditLimit.Focus();
                }
                else if (dbCreditLimit > 0 && cmbAccountType.Text.Equals("Saving"))
                {
                    MessageBox.Show("There is no Credit Limit for Saving Account", "Error Message");
                    txtCreditLimit.Focus();
                }
                 else if(dbBalance<=0)
                { 
                     MessageBox.Show("Balance should be greater than Zero", "Error Message");
                     txtBalance.Focus();
                }
                //else if (dtDateofBirth.DayOfYear > dtCurrentDate.DayOfYear)
                else if (DateTime.Compare(dtDateofBirth, dtCurrentDate)>0)
                {
                    MessageBox.Show("Date of Birth cannot be greater than Current Date", "Error Message");
                    txtDateofBirth.Focus();
                }
                else if (DateTime.Compare(dtOpDate, dtCurrentDate)>0)
                {
                    MessageBox.Show("Opening Date cannot be greater than Current Date", "Error Message");
                    txtOpeningDate.Focus();
                }
                else
                {
                    String conStr = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = conStr;
                    con.Open();

                    String str = "insert ACCOUNTS(ACNO,ACCOUNT_TYPE,CREDIT_LIMIT,NAME,ADDRESS,BALANCE,PHONE_NO,DATE_OF_BIRTH,OPENING_DATE,AC_IMAGE) values(@acno,@actype,@credit_limit,@name,@address,@balance,@phoneno,@dateofbirth,@opdate,@acimage)";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.CommandType = CommandType.Text;

                    SqlParameter spacno;
                    spacno = cmd.Parameters.Add("@acno", SqlDbType.Char, 6);
                    spacno.Value = cmbACNO.Text;

                    SqlParameter spactype;
                    spactype = cmd.Parameters.Add("@actype", SqlDbType.VarChar,10);
                    spactype.Value = cmbAccountType.Text;

                    SqlParameter spcredit_limit;
                    spcredit_limit = cmd.Parameters.Add("@credit_limit", SqlDbType.Money);
                    spcredit_limit.Value = dbCreditLimit;

                    SqlParameter spname;
                    spname = cmd.Parameters.Add("@name", SqlDbType.VarChar, 30);
                    spname.Value = txtName.Text;

                    SqlParameter spaddress;
                    spaddress = cmd.Parameters.Add("@address", SqlDbType.VarChar, 50);
                    spaddress.Value = txtAddress.Text;

                    SqlParameter spbalance;
                    spbalance = cmd.Parameters.Add("@balance", SqlDbType.Money);
                    spbalance.Value = dbBalance;

                    SqlParameter spPhoneNumber;
                    spPhoneNumber = cmd.Parameters.Add("@phoneno", SqlDbType.VarChar,15);
                    spPhoneNumber.Value = txtPhoneNumber.Text;

                    SqlParameter spdateofbirth;
                    spdateofbirth = cmd.Parameters.Add("@dateofbirth", SqlDbType.DateTime);
                    spdateofbirth.Value = dtDateofBirth;               

                    SqlParameter spopdate;
                    spopdate = cmd.Parameters.Add("@opdate", SqlDbType.DateTime);
                    spopdate.Value = dtOpDate;

                    SqlParameter spacimage;
                    spacimage = cmd.Parameters.Add("@acimage", SqlDbType.VarChar, 100);
                    spacimage.Value = pictureBox1.ImageLocation;

                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Record has been Saved", "Message");
                    cmdSave.Enabled = false;
                    cmdCancel.Enabled = false;
                    cmbACNO.Enabled = true;
                    String str2 = "SELECT ACNO FROM ACCOUNTS";
                    SqlCommand cmd2 = new SqlCommand(str2, con);
                    cmd2.CommandType = CommandType.Text;

                    SqlDataReader reader;
                    reader = cmd2.ExecuteReader();
                    cmbACNO.Items.Clear();
                    while (reader.Read())
                    {
                        cmbACNO.Items.Add(Convert.ToString(reader["ACNO"]));
                    }
                    con.Close();
                }
            }
        }


      

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (cmbACNO.Text == "")
            {
                MessageBox.Show("Please Enter Account Number", "Error Message");
                cmbACNO.Focus();
            }
            else if (cmbAccountType.Text == "")
            {
                MessageBox.Show("Please Select Account Type", "Error Message");
                cmbAccountType.Focus();
            }
            else if (txtCreditLimit.Text == "")
            {
                MessageBox.Show("Please Enter Credit Limit", "Error Message");
                txtCreditLimit.Focus();
            }    
            else if (txtName.Text == "")
            {
                MessageBox.Show("Please Enter Name", "Error Message");
                txtName.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Address", "Error Message");
                txtAddress.Focus();
            }
            else if (txtBalance.Text == "")
            {
                MessageBox.Show("Please Enter Balance", "Error Message");
                txtBalance.Focus();
            }
            else if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Please Enter Phone Number", "Error Message");
                txtPhoneNumber.Focus();
            }
            else if (txtDateofBirth.Text == "")
            {
                MessageBox.Show("Please Enter Date of Birth", "Error Message");
                txtDateofBirth.Focus();
            }
            else if (txtOpeningDate.Text == "")
            {
                MessageBox.Show("Please Enter Opening Date", "Error Message");
                txtOpeningDate.Focus();
            }
            else if (pictureBox1.ImageLocation.Length == 0)
            {
                MessageBox.Show("Please Select the Image", "Error Message");
                btnBrowse.Focus();
            }
            else
            {
                String strCreditLimit, strBalance, strPhoneno, strPart;
                int ctr;

                strCreditLimit = txtCreditLimit.Text;
                for (ctr = 0; ctr < strCreditLimit.Length; ctr++)
                {
                    strPart = strCreditLimit.Substring(ctr, 1);
                    if (!char.IsDigit(Convert.ToChar(strPart)) && Convert.ToChar(strPart) != '.')
                    {
                        MessageBox.Show("Credit Limit can contains Digits [0-9] and Dot only", "Error Message");
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

                double dbBalance, dbCreditLimit;
                dbBalance = Convert.ToDouble(txtBalance.Text);
                dbCreditLimit = Convert.ToDouble(txtCreditLimit.Text);
                DateTime dtOpDate, dtDateofBirth, dtCurrentDate;
                dtOpDate = Convert.ToDateTime(txtOpeningDate.Text);
                dtDateofBirth = Convert.ToDateTime(txtDateofBirth.Text);
                dtCurrentDate = DateTime.Now;
                if (dbCreditLimit < 0)
                {
                    MessageBox.Show("Credit Limit should be greater than Zero", "Error Message");
                    txtCreditLimit.Focus();
                }
                else if (dbCreditLimit > 0 && cmbAccountType.Text.Equals("Saving"))
                {
                    MessageBox.Show("There is no Credit Limit for Saving Account", "Error Message");
                    txtCreditLimit.Focus();
                }
                else if (dbBalance <= 0)
                {
                    MessageBox.Show("Balance should be greater than Zero", "Error Message");
                    txtBalance.Focus();
                }
                //else if (dtDateofBirth.DayOfYear > dtCurrentDate.DayOfYear)
                else if (DateTime.Compare(dtDateofBirth, dtCurrentDate) > 0)
                {
                    MessageBox.Show("Date of Birth cannot be greater than Current Date", "Error Message");
                    txtDateofBirth.Focus();
                }
                else if (DateTime.Compare(dtOpDate, dtCurrentDate) > 0)
                {
                    MessageBox.Show("Opening Date cannot be greater than Current Date", "Error Message");
                    txtOpeningDate.Focus();
                }
               
                else
                {
                    String conStr = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = conStr;
                    con.Open();
                    String str = "UPDATE ACCOUNTS SET ACCOUNT_TYPE=@actype,CREDIT_LIMIT=@credit_limit,NAME=@name,ADDRESS=@address,BALANCE=@balance,PHONE_NO=@phoneno,DATE_OF_BIRTH=@dateofbirth,OPENING_DATE=@opdate,AC_IMAGE=@acimage WHERE ACNO=@acno ";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.CommandType = CommandType.Text;

                    SqlParameter spactype;
                    spactype = cmd.Parameters.Add("@actype", SqlDbType.VarChar, 10);
                    spactype.Value = cmbAccountType.Text;

                    SqlParameter spcredit_limit;
                    spcredit_limit = cmd.Parameters.Add("@credit_limit", SqlDbType.Money);
                    spcredit_limit.Value = dbCreditLimit;

                    SqlParameter spname;
                    spname = cmd.Parameters.Add("@name", SqlDbType.VarChar, 30);
                    spname.Value = txtName.Text;

                    SqlParameter spaddress;
                    spaddress = cmd.Parameters.Add("@address", SqlDbType.VarChar, 50);
                    spaddress.Value = txtAddress.Text;

                    SqlParameter spbalance;
                    spbalance = cmd.Parameters.Add("@balance", SqlDbType.Money);
                    spbalance.Value = dbBalance;

                    SqlParameter spPhoneNumber; 
                    spPhoneNumber = cmd.Parameters.Add("@phoneno", SqlDbType.VarChar, 15);
                    spPhoneNumber.Value = txtPhoneNumber.Text;

                    SqlParameter spdateofbirth;
                    spdateofbirth = cmd.Parameters.Add("@dateofbirth", SqlDbType.DateTime);
                    spdateofbirth.Value = dtDateofBirth;          

                    SqlParameter spopdate;
                    spopdate = cmd.Parameters.Add("@opdate", SqlDbType.DateTime);
                    spopdate.Value = dtOpDate;

                    SqlParameter spacimage;
                    spacimage = cmd.Parameters.Add("@acimage", SqlDbType.VarChar, 100);
                    spacimage.Value = pictureBox1.ImageLocation;

                    SqlParameter spacno;
                    spacno = cmd.Parameters.Add("@acno", SqlDbType.Char, 6);
                    spacno.Value = cmbACNO.Text;

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been Udated", "Message");
                }
            }
        }
      
        private void frmMain_Load(object sender, EventArgs e)
        {
            String conStr = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conStr;
            con.Open();
            String str = "SELECT * FROM ACCOUNTS ORDER BY ACNO";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

           SqlDataReader reader;
            reader = cmd.ExecuteReader();
            cmbACNO.Items.Clear();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    cmbACNO.Items.Add(Convert.ToString(reader["ACNO"]));
                }
            }
            else
            {
                MessageBox.Show("Record did not Find", "Error Message");
            }
        
            con.Close();

            cmbAccountType.Items.Add("Saving");
            cmbAccountType.Items.Add("Current");
           cmbAccountType.DropDownStyle = ComboBoxStyle.DropDownList;

            cmdSave.Enabled = false;
            cmdCancel.Enabled = false;
            txtOpeningDate.Enabled = false;
            txtDateofBirth.Enabled = false;
            
            ////////////////////////////////////////
            String conStr2 = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = conStr2;
            con2.Open();
            String str2 = "SELECT * FROM ACCOUNTS ORDER BY ACNO";
            SqlCommand cmd2 = new SqlCommand(str2, con2);
            cmd2.CommandType = CommandType.Text;

            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();
            if (reader2.HasRows == true)
            {
                dgvAccountDetails.DataSource = null;
                DataTable datatable1 = new DataTable();
                datatable1.Load(reader2);
                dgvAccountDetails.DataSource = datatable1;

            }           
            con2.Close();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (cmbACNO.Text == "")
            {
                MessageBox.Show("Please Enter Account Number", "Error Message");
                cmbACNO.Focus();
            }
            else
            {
                String conStr = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conStr;
                con.Open();
                String str = "DELETE ACCOUNTS WHERE ACNO=@acno";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.Text;

                SqlParameter spacno;
                spacno = cmd.Parameters.Add("@acno", SqlDbType.Char, 6);
                spacno.Value = cmbACNO.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record has been Deleted", "Error Message");


                String str2 = "SELECT * FROM ACCOUNTS";
                SqlCommand cmd2 = new SqlCommand(str2, con);
                cmd2.CommandType = CommandType.Text;

                SqlDataReader reader;
                reader = cmd2.ExecuteReader();
                reader.Read();
                if (reader.HasRows == true)
                {
                    cmbAccountType.Text = Convert.ToString(reader["ACCOUNT_TYPE"]);
                    txtCreditLimit.Text = Convert.ToString(reader["CREDIT_LIMIT"]);
                    cmbACNO.Text = Convert.ToString(reader["ACNO"]);
                    txtName.Text = Convert.ToString(reader["NAME"]);
                    txtAddress.Text = Convert.ToString(reader["ADDRESS"]);
                    txtBalance.Text = Convert.ToString(reader["BALANCE"]);
                    txtPhoneNumber.Text = Convert.ToString(reader["PHONE_NO"]);
                    txtDateofBirth.Text = Convert.ToString(reader["DATE_OF_BIRTH"]);
                    txtOpeningDate.Text = Convert.ToString(reader["OPENING_DATE"]);
                }
                else
                {
                    cmbACNO.Text = "";
                    cmbAccountType.SelectedIndex = -1;
                    txtCreditLimit.Text = "";
                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtBalance.Text = "";
                    txtPhoneNumber.Text = "";
                    txtDateofBirth.Text = "";
                    txtOpeningDate.Text = "";
                    pictureBox1.ImageLocation = "";
                    MessageBox.Show("Record did not Find", "Error Message");
                }
                con.Close();

                String conStr3 = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
                SqlConnection con3 = new SqlConnection();
                con3.ConnectionString = conStr3;
                con3.Open();
                String str3 = "SELECT ACNO FROM ACCOUNTS";
                SqlCommand cmd3 = new SqlCommand(str3, con3);
                cmd3.CommandType = CommandType.Text;

                SqlDataReader reader3;
                reader3 = cmd3.ExecuteReader();
                cmbACNO.Items.Clear();
                while (reader3.Read())
                {
                    cmbACNO.Items.Add(Convert.ToString(reader3["ACNO"]));
                }
                con3.Close();               
            }
        }

        private void cmbACNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbACNO.Text == "")
            {
                MessageBox.Show("Please Enter Account Number", "Error Message");
                cmbACNO.Focus();
            }
            else
            {
                String conStr = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conStr;
                con.Open();
                String str = "SELECT * FROM ACCOUNTS WHERE ACNO=@acno";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.Text;

                SqlParameter spacno;
                spacno = cmd.Parameters.Add("@acno", SqlDbType.Char, 6);
                spacno.Value = cmbACNO.Text;


                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows == true)
                {
                    cmbAccountType.Text = Convert.ToString(reader["ACCOUNT_TYPE"]);
                    txtCreditLimit.Text = Convert.ToString(reader["CREDIT_LIMIT"]);
                    txtName.Text = Convert.ToString(reader["NAME"]);
                    txtAddress.Text = Convert.ToString(reader["ADDRESS"]);
                    txtBalance.Text = Convert.ToString(reader["BALANCE"]);
                    txtPhoneNumber.Text = Convert.ToString(reader["PHONE_NO"]);
                    txtDateofBirth.Text = Convert.ToString(reader["DATE_OF_BIRTH"]);
                    txtOpeningDate.Text = Convert.ToString(reader["OPENING_DATE"]);
                    pictureBox1.ImageLocation = Convert.ToString(reader["AC_IMAGE"]);
                    
                }
                else
                {
                    MessageBox.Show("Record did not Find", "Error Message");
                }
            }
        }        
        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
           openFileDialog1.ShowDialog();
           pictureBox1.ImageLocation=openFileDialog1.FileName;
           
        }

        private void dtDateofBirth_ValueChanged(object sender, EventArgs e)
        {
            DateTime DateofBirth;
            DateofBirth = dtDateofBirth.Value;
            txtDateofBirth.Text = Convert.ToString(DateofBirth.Date);
          
        }

        private void dtOpeningDate_ValueChanged(object sender, EventArgs e)
        {
            txtOpeningDate.Text = Convert.ToString(dtOpeningDate.Value);
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (cmbACNO.Text == "")
            {
                MessageBox.Show("Please Enter Account Number", "Error Message");
                cmbACNO.Focus();
            }
            else
            {
                String conStr = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conStr;
                con.Open();
                String str = "SELECT * FROM ACCOUNTS WHERE ACNO=@acno";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.Text;

                SqlParameter spacno;
                spacno = cmd.Parameters.Add("@acno", SqlDbType.Char, 6);
                spacno.Value = cmbACNO.Text;


                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows == true)
                {
                    cmbAccountType.Text = Convert.ToString(reader["ACCOUNT_TYPE"]);
                    txtCreditLimit.Text = Convert.ToString(reader["CREDIT_LIMIT"]);
                    txtName.Text = Convert.ToString(reader["NAME"]);
                    txtAddress.Text = Convert.ToString(reader["ADDRESS"]);
                    txtBalance.Text = Convert.ToString(reader["BALANCE"]);
                    txtPhoneNumber.Text = Convert.ToString(reader["PHONE_NO"]);
                    txtDateofBirth.Text = Convert.ToString(reader["DATE_OF_BIRTH"]);
                    txtOpeningDate.Text = Convert.ToString(reader["OPENING_DATE"]);
                    pictureBox1.ImageLocation = Convert.ToString(reader["AC_IMAGE"]);

                }
                else
                {
                    MessageBox.Show("Record did not Find", "Error Message");
                }
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            cmbACNO.Text = "";
            cmbACNO.Enabled = true;
            cmbAccountType.SelectedIndex = -1;
            txtCreditLimit.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtBalance.Text = "";
            txtPhoneNumber.Text = "";
            txtDateofBirth.Text = "";
            txtOpeningDate.Text = "";
            pictureBox1.ImageLocation = "";
            cmdCancel.Enabled = false;
            cmdSave.Enabled = false;      
        }

        private void cmdacTypeDetails_Click(object sender, EventArgs e)
        {
            if (cmbAccountType.SelectedIndex != -1)
            {
                if (cmbAccountType.Text == "")
                {
                MessageBox.Show("Please Select Account Type", "Error Message");
                cmbAccountType.Focus();
                 }
                else
                {
                    String conStr = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = conStr;
                    con.Open();
                    String str = "SELECT * FROM ACCOUNTS WHERE ACCOUNT_TYPE=@actype";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.CommandType = CommandType.Text;

                    SqlParameter spactype;
                    spactype = cmd.Parameters.Add("@actype", SqlDbType.Char, 10);
                    spactype.Value = cmbAccountType.Text;                   

                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        dgvAccountDetails.DataSource = null;
                        DataTable datatable1 = new DataTable();
                        datatable1.Load(reader);
                        dgvAccountDetails.DataSource = datatable1;

                    }
                    else
                    {
                        MessageBox.Show("Record did not Find", "Error Message");
                    }
                    con.Close();
                }

            }
        }

        private void cmdAllAccountsDetails_Click(object sender, EventArgs e)
        {
            String conStr = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conStr;
            con.Open();
            String str = "SELECT * FROM ACCOUNTS";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                dgvAccountDetails.DataSource = null;
                DataTable datatable1 = new DataTable();
                datatable1.Load(reader);
                dgvAccountDetails.DataSource = datatable1;

            }
            else
            {
                MessageBox.Show("Record did not Find", "Error Message");
            }
            con.Close();

        }

        

       
    }
}