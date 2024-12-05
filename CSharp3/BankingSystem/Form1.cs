using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace BankingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbAccountNumber.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Account Number", "Error Message");
                cmbAccountNumber.Focus();
            }
            else if (cmbAccountType.Text.Length == 0)
            {
                MessageBox.Show("Please Select Account Type", "Error Message");
                cmbAccountType.Focus();
            }
            else if (txtFirstName.Text.Length == 0)
            {
                MessageBox.Show("Please Enter First Name", "Error Message");
                txtFirstName.Focus();
            }
            /*else if (txtLastName.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Last Name", "Error Message");
                txtLastName.Focus();
            }*/
            else if (txtAddress.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Address", "Error Message");
                txtAddress.Focus();
            }
            else if (cmbState.Text.Length == 0)
            {
                MessageBox.Show("Please Select the State", "Error Message");
                cmbState.Focus();
            }
            else if (cmbCity.Text.Length == 0)
            {
                MessageBox.Show("Please Select the City", "Error Message");
                cmbCity.Focus();
            }
            else if (txtMobile.Text.Length != 10)
            {
                MessageBox.Show("Mobile Number must be for 10 Numbers", "Error Message");
                txtMobile.Focus();
            }
            else if (dtpDateOfBirth.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Date of Birth", "Error Message");
                dtpDateOfBirth.Focus();
            }
            else if (dtpOpeningDate.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Opening Date", "Error Message");
                dtpOpeningDate.Focus();
            }
            else if (txtBalance.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Balance", "Error Message");
                txtBalance.Focus();
            }
            else if (txtEmailId.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Email Id", "Error Message");
                txtEmailId.Focus();
            }
            else if (pictureBox1.ImageLocation == null)
            {
                MessageBox.Show("Please Select the Image", "Error Message");                
            }
            else if (rbMale.Checked == false && rbFemale.Checked == false)
            {
                MessageBox.Show("Please Select the Gender", "Error Message");
                rbMale.Focus();
            }
            else
            {
                String strFirstName, strLastName, strState,strCity,strMobile,strBalance,strEmailId,strPart;
                int ctr;

                //First Name Validation
                strFirstName = txtFirstName.Text;
                for (ctr = 0; ctr < strFirstName.Length; ctr++)
                {
                    strPart = strFirstName.Substring(ctr, 1);
                    if (!char.IsLetterOrDigit(Convert.ToChar(strPart)) && Convert.ToChar(strPart) != ' ' && Convert.ToChar(strPart) != '.')
                    {
                        MessageBox.Show("First Name can contains Alphabets, Digits [0-9], space and Dot only", "Error Message");
                        txtFirstName.Focus();
                        return;
                    }
                }

                //Last Name Validation
                strLastName = txtLastName.Text;
                for (ctr = 0; ctr < strLastName.Length; ctr++)
                {
                    strPart = strLastName.Substring(ctr, 1);
                    if (!char.IsLetterOrDigit(Convert.ToChar(strPart)) && Convert.ToChar(strPart) != ' ' && Convert.ToChar(strPart) != '.')
                    {
                        MessageBox.Show("Last Name can contains Alphabets, Digits [0-9], space and Dot only", "Error Message");
                        txtLastName.Focus();
                        return;
                    }
                }

                //State Validation
                strState = cmbState.Text;
                for (ctr = 0; ctr < strState.Length; ctr++)
                {
                    strPart = strState.Substring(ctr, 1);
                    if (!char.IsLetter(Convert.ToChar(strPart)) && Convert.ToChar(strPart) != ' ')
                    {
                        MessageBox.Show("State can contains Alphabets, and space only", "Error Message");
                        cmbState.Focus();
                        return;
                    }
                }

                //City Validation
                strCity = cmbCity.Text;
                for (ctr = 0; ctr < strCity.Length; ctr++)
                {
                    strPart = strCity.Substring(ctr, 1);
                    if (!char.IsLetter(Convert.ToChar(strPart)) && Convert.ToChar(strPart) != ' ')
                    {
                        MessageBox.Show("City can contains Alphabets, and space only", "Error Message");
                        cmbCity.Focus();
                        return;
                    }
                }

                //Mobile Validation
                strMobile = txtMobile.Text;
                for (ctr = 0; ctr < strMobile.Length; ctr++)
                {
                    strPart = strMobile.Substring(ctr, 1);
                    if (!char.IsDigit(Convert.ToChar(strPart)))
                    {
                        MessageBox.Show("Mobile Number can contains Digits [0-9] only", "Error Message");
                        return;
                    }
                }

                //Balance Validation
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

                //EmailId Validation
                strEmailId = txtEmailId.Text;
                for (ctr = 0; ctr < strEmailId.Length; ctr++)
                {
                    strPart = strEmailId.Substring(ctr, 1);
                    if (!char.IsLetterOrDigit(Convert.ToChar(strPart)) && Convert.ToChar(strPart) != '_' && Convert.ToChar(strPart) != '.' && Convert.ToChar(strPart) != '@')
                    {
                        MessageBox.Show("Email Id can contains Alphabets, Digits [0-9], Undderscore, Dot and @ only", "Error Message");
                        txtEmailId.Focus();
                        return;
                    }
                }

                //Range Validation
                double dbBalance;
                dbBalance = Convert.ToDouble(txtBalance.Text);

                DateTime dtOpeningDate, dtDateOfBirth, dtCurrentDate;
                dtOpeningDate = Convert.ToDateTime(dtpOpeningDate.Text);
                dtDateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Text);
                dtCurrentDate = DateTime.Now;
                
                if (dbBalance <= 0)
                {
                    MessageBox.Show("Balance should be greater than Zero", "Error Message");
                    txtBalance.Focus();
                }
                //else if (dtDateofBirth.DayOfYear > dtCurrentDate.DayOfYear)
                else if (DateTime.Compare(dtDateOfBirth, dtCurrentDate) > 0)
                {
                    MessageBox.Show("Date of Birth cannot be greater than Current Date", "Error Message");
                    dtpDateOfBirth.Focus();
                }
                else if (DateTime.Compare(dtOpeningDate, dtCurrentDate) > 0)
                {
                    MessageBox.Show("Opening Date cannot be greater than Current Date", "Error Message");
                    dtpOpeningDate.Focus();
                }
                else
                {
                    try
                    {
                        String conStr = "Data Source=AA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = conStr;
                        con.Open();

                        String str = "INSERT ACCOUNTS(ACNO,ACCOUNT_TYPE,FIRST_NAME,LAST_NAME,ADDRESS,STATE,CITY,BALANCE,MOBILE,DATE_OF_BIRTH,OPENING_DATE,EMAIL,AC_IMAGE,GENDER,DEBIT_CARD,CREDIT_CARD,ONLINE_BANKING) values(@acno,@actype,@first_name,@last_name,@address,@state,@city,@balance,@mobile,@dateofbirth,@openingdate,@email,@acimage,@gender,@debit_card,@credit_card,@online_banking)";
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

                        SqlParameter spbalance;
                        spbalance = cmd.Parameters.Add("@balance", SqlDbType.Money);
                        spbalance.Value = dbBalance;

                        SqlParameter spmobile;
                        spmobile = cmd.Parameters.Add("@mobile", SqlDbType.VarChar, 10);
                        spmobile.Value = txtMobile.Text;

                        SqlParameter spdateofbirth;
                        spdateofbirth = cmd.Parameters.Add("@dateofbirth", SqlDbType.DateTime);
                        spdateofbirth.Value = dtDateOfBirth;

                        SqlParameter spopeningdate;
                        spopeningdate = cmd.Parameters.Add("@openingdate", SqlDbType.DateTime);
                        spopeningdate.Value = dtOpeningDate;

                        SqlParameter spemail;
                        spemail = cmd.Parameters.Add("@email", SqlDbType.VarChar, 80);
                        spemail.Value = txtEmailId.Text;

                        SqlParameter spacimage;
                        spacimage = cmd.Parameters.Add("@acimage", SqlDbType.VarChar, 100);
                        spacimage.Value = pictureBox1.ImageLocation;

                        String strGender = "";
                        Boolean blnDebitCard, blnCreditCard, blnOnlineBanking;

                        if (rbMale.Checked == true)
                        {
                            strGender = "Male";
                        }
                        if (rbFemale.Checked == true)
                        {
                            strGender = "Female";
                        }
                        if (cbDebitCard.Checked == true)
                        {
                            blnDebitCard = true;
                        }
                        else
                        {
                            blnDebitCard = false;
                        }
                        if (cbCreditCard.Checked == true)
                        {
                            blnCreditCard = true;
                        }
                        else
                        {
                            blnCreditCard = false;
                        }
                        if (cbOnlineBanking.Checked == true)
                        {
                            blnOnlineBanking = true;
                        }
                        else
                        {
                            blnOnlineBanking = false;
                        }

                        SqlParameter spgender;
                        spgender = cmd.Parameters.Add("@gender", SqlDbType.VarChar, 10);
                        spgender.Value = strGender;

                        SqlParameter spdebit_card;
                        spdebit_card = cmd.Parameters.Add("@debit_card", SqlDbType.Bit);
                        spdebit_card.Value = blnDebitCard;

                        SqlParameter spcredit_card;
                        spcredit_card = cmd.Parameters.Add("@credit_card", SqlDbType.Bit);
                        spcredit_card.Value = blnCreditCard;

                        SqlParameter sponline_banking;
                        sponline_banking = cmd.Parameters.Add("@online_banking", SqlDbType.Bit);
                        sponline_banking.Value = blnOnlineBanking;

                        cmd.ExecuteNonQuery();

                        String str2 = "SELECT ACNO FROM ACCOUNTS";
                        SqlCommand cmd2 = new SqlCommand(str2, con);
                        cmd2.CommandType = CommandType.Text;

                        SqlDataReader reader;
                        reader = cmd2.ExecuteReader();
                        cmbAccountNumber.Items.Clear();
                        while (reader.Read())
                        {
                            cmbAccountNumber.Items.Add(Convert.ToString(reader["ACNO"]));
                        }
                        con.Close();
                        MessageBox.Show("Record has been Saved", "Message");
                    }
                    catch(Exception obj)
                    {
                        MessageBox.Show(obj.Message);
                    }
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAccountType.Items.Add("Saving");
            cmbAccountType.Items.Add("Current");

            cmbState.Items.Add("Andhra Pradesh");
            cmbState.Items.Add("Delhi");
            cmbState.Items.Add("Madhya Pradesh");
            cmbState.Items.Add("Uttrakhand");
            cmbState.Items.Add("Uttar Pradesh");
            cmbState.Sorted = true;
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbState.Text.Length == 0)
            {
                MessageBox.Show("Please Select the State");
                cmbState.Focus();
            }
            else if (cmbState.Text == "Andhra Pradesh")
            {
                cmbCity.Items.Clear();
                cmbCity.Items.Add("Hydrabad");
                cmbCity.Items.Add("Tirupati");
                cmbCity.Items.Add("Vishakhapattanam");
                cmbCity.Sorted = true;
            }
            else if (cmbState.Text == "Madhya Pradesh")
            {
                cmbCity.Items.Clear();
                cmbCity.Items.Add("Muraina");
                cmbCity.Items.Add("Indore");
                cmbCity.Items.Add("Bhopal");
                cmbCity.Sorted = true;
            }
            else if (cmbState.Text == "Uttar Pradesh")
            {
                cmbCity.Items.Clear();
                cmbCity.Items.Add("Meerut");
                cmbCity.Items.Add("Noida");
                cmbCity.Items.Add("Kanpur");
                cmbCity.Sorted = true;
            }
            else if (cmbState.Text == "Uttrakhand")
            {
                cmbCity.Items.Clear();
                cmbCity.Items.Add("Dehadun");
                cmbCity.Items.Add("Haridwar");
                cmbCity.Items.Add("Tehri");
                cmbCity.Sorted = true;
            }
            else if (cmbState.Text == "Delhi")
            {
                cmbCity.Items.Clear();
                cmbCity.Items.Add("East Delhi");
                cmbCity.Items.Add("North Delhi");
                cmbCity.Items.Add("South Delhi");
                cmbCity.Items.Add("West Delhi");
                cmbCity.Sorted = true;
            }
            else
            {

                MessageBox.Show("Invalid State");
                cmbState.Focus();
            }
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation == null)
            {
                MessageBox.Show("Please Select the Image", "Error Message");
                openFileDialog1.ShowDialog();
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                if (pictureBox1.Width > 165 || pictureBox1.Height > 130)
                {
                    MessageBox.Show("Image Width = " + pictureBox1.Width.ToString() + "pixels\n" +
                                     "Image Width = " + pictureBox1.Height.ToString() + "pixels\n\n" +
                                     "Image Width can not be greater than 165" +
                                     "and Height can not greater than 130 pixels");
                }
            }
            else
            {
                openFileDialog1.ShowDialog();
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                if (pictureBox1.Width > 165 || pictureBox1.Height > 130)
                {
                    MessageBox.Show("Image Width = " + pictureBox1.Width.ToString() + "pixels\n" +
                                     "Image Width = " + pictureBox1.Height.ToString() + "pixels\n\n" +
                                     "Image Width can not be greater than 165" +
                                     "and Height can not greater than 130 pixels");
                }
            }

        }       
       
    }
}
