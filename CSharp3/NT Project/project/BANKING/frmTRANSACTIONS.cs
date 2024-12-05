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
    public partial class frmTRANSACTIONS : Form
    {
        public frmTRANSACTIONS()
        {
            InitializeComponent();
        }

        private void frmTRANSACTIONS_Load(object sender, EventArgs e)
        {
             ////////////////////////////////////////////////////////////
            String conStr = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conStr;
            con.Open();

            String str2 = "SELECT TRAN_ID FROM TRANSACTIONS ORDER BY TRAN_ID";
            SqlCommand cmd2 = new SqlCommand(str2, con);
            cmd2.CommandType = CommandType.Text;

            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();
            cmbTranactionNo.Items.Clear();
            if (reader2.HasRows == true)
            {
                while (reader2.Read())
                {
                    cmbTranactionNo.Items.Add(Convert.ToString(reader2["TRAN_ID"]));
                }
            }
            else
            {
                MessageBox.Show("Record did not Find in TRANSACTIONS Table", "Error Message");
            }
            reader2.Close();
            //////////////////////////////////////////////////////////////////////
            
            String str = "SELECT ACNO FROM ACCOUNTS";
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
                MessageBox.Show("Record did not Find in ACCOUNTS Table", "Error Message");
            }

            con.Close();

            cmbTranactionType.Items.Add("Deposit");
            cmbTranactionType.Items.Add("Withdrwal");
         
            cmbDocumentType.Items.Add("Slip");
            cmbDocumentType.Items.Add("Cheque");

            cmbACNO.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTranactionType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDocumentType.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBalance.Enabled = false;
            txtAccountType.Enabled = false;
            txtCreditLimit.Enabled = false;
            txtTranactionDate.Enabled = false;
            cmdSave.Enabled = false;
            cmdCancel.Enabled = false;
        }
     
        private void cmbACNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbACNO.SelectedIndex != -1)
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
                                         
                        txtAccountType.Text = Convert.ToString(reader["ACCOUNT_TYPE"]);
                        txtCreditLimit.Text = Convert.ToString(reader["CREDIT_LIMIT"]);
                        txtBalance.Text = Convert.ToString(reader["BALANCE"]);
                        pictureBox1.ImageLocation = Convert.ToString(reader["AC_IMAGE"]);            
                    }
                    else
                    {
                        MessageBox.Show("Record did not Find", "Error Message");    
                    
                    }
                    con.Close(); 
                    ///////////////////////////////
                    /////////////////////////////////////////
                    String conStr2 = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
                    SqlConnection con2 = new SqlConnection();
                    con2.ConnectionString = conStr2;
                    con2.Open();
                    String str2 = "SELECT * FROM ACCOUNTS WHERE ACNO=@acno";
                    SqlCommand cmd2 = new SqlCommand(str2, con2);
                    cmd2.CommandType = CommandType.Text;

                    SqlParameter spacno2;
                    spacno2 = cmd2.Parameters.Add("@acno", SqlDbType.Char, 6);
                    spacno2.Value = cmbACNO.Text;

                    SqlDataReader reader2;
                    reader2 = cmd2.ExecuteReader();
                    if (reader2.HasRows == true)
                    {
                        dgvAccountDetails.DataSource = null;
                        DataTable datatable1 = new DataTable();
                        datatable1.Load(reader2);
                        dgvAccountDetails.DataSource = datatable1;

                    }
                    else
                    {
                        MessageBox.Show("Record did not Find", "Error Message");
                    }
                    con2.Close(); 
                }      
                 
           }
        }

     

        private void dtTranactionDate_ValueChanged(object sender, EventArgs e)
        {
            txtTranactionDate.Text = Convert.ToString(dtTranactionDate.Value);
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            String conStr = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conStr;
            con.Open();
            String str = "SELECT TRAN_ID FROM TRANSACTIONS ORDER BY TRAN_ID ASC";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            String strTRAN_ID, strTRAN_IDPart;
            int intTRAN_ID;
            strTRAN_ID = "";
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    strTRAN_ID = Convert.ToString(reader["TRAN_ID"]);
                }
                strTRAN_IDPart = strTRAN_ID.Substring(1, 5);
                intTRAN_ID = Convert.ToInt32(strTRAN_IDPart);
                intTRAN_ID++;
               
                strTRAN_IDPart = Convert.ToString(intTRAN_ID);
                if ((intTRAN_ID >= 1) && (intTRAN_ID <= 9))
                {
                    strTRAN_ID = "T0000" + strTRAN_IDPart;
                }
                else if ((intTRAN_ID >= 10) && (intTRAN_ID <= 99))
                {
                    strTRAN_ID = "T000" + strTRAN_IDPart;
                }
                else if ((intTRAN_ID >= 100) && (intTRAN_ID <= 999))
                {
                    strTRAN_ID = "T00" + strTRAN_IDPart;
                }
                else if ((intTRAN_ID >= 1000) && (intTRAN_ID <= 9999))
                {
                    strTRAN_ID = "T0" + strTRAN_IDPart;
                }
                else
                {
                    strTRAN_ID = "T" + strTRAN_IDPart;
                }
               cmbTranactionNo.Text = strTRAN_ID;
            }
            else
            {
               cmbTranactionNo.Text = "T00001";
                MessageBox.Show("Record did not Find", "Error Message");
            }

            con.Close();
            cmbTranactionNo.Enabled = false;
            cmbACNO.SelectedIndex = -1; ;
            txtAccountType.Text = "";
            txtCreditLimit.Text = "";
            txtBalance.Text = "";
            cmbTranactionType.SelectedIndex = -1;
            txtAmount.Text = "";
            cmbDocumentType.SelectedIndex = -1;
            txtDocumentNumber.Text = "";
            txtTranactionDate.Text = "";
            pictureBox1.ImageLocation = "";

            cmdSave.Enabled = true;
            cmdCancel.Enabled = true;           
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (cmbTranactionNo.Text == "")
            {
                MessageBox.Show("Please Select Tranaction Number", "Error Message");
                cmbTranactionNo.Focus();
            }
            else
            {
                String conStr = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conStr;
                con.Open();
                String str = "SELECT * FROM TRANSACTIONS WHERE TRAN_ID=@tranid";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.Text;

                SqlParameter sptranid;
                sptranid = cmd.Parameters.Add("@tranid", SqlDbType.Char, 6);
                sptranid.Value = cmbTranactionNo.Text;

                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows == true)
                {
                    cmbTranactionNo.Text = Convert.ToString(reader["TRAN_ID"]);
                    cmbACNO.Text = Convert.ToString(reader["ACNO"]);
                    cmbTranactionType.Text = Convert.ToString(reader["TRAN_TYPE"]);
                    txtAmount.Text = Convert.ToString(reader["AMOUNT"]);
                    cmbDocumentType.Text = Convert.ToString(reader["DOC_TYPE"]);
                    txtDocumentNumber.Text = Convert.ToString(reader["DOC_NUMBER"]);
                    txtTranactionDate.Text = Convert.ToString(reader["TRAN_DATE"]);          
                }
                else
                {
                    MessageBox.Show("Record did not Find", "Error Message");
                }
            }

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            cmbTranactionNo.Enabled = true; ;
            cmbACNO.SelectedIndex = -1;
            txtAccountType.Text = "";
            txtCreditLimit.Text = "";
            txtBalance.Text = "";
            cmbTranactionType.SelectedIndex = -1;
            txtAmount.Text = "";
            cmbDocumentType.SelectedIndex = -1;
            txtDocumentNumber.Text = "";
            txtTranactionDate.Text = "";
            cmdSave.Enabled = false;
            cmdCancel.Enabled = false;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (cmbTranactionNo.Text == "")
            {
                MessageBox.Show("Please Enter Tranaction Number", "Error Message");
                cmbTranactionNo.Focus();
            }
            else if (cmbACNO.Text == "")
            {
                MessageBox.Show("Please Select Account Number", "Error Message");
                cmbACNO.Focus();
            }
            else if (txtAccountType.Text == "")
            {
                MessageBox.Show("Please Enter Account Type", "Error Message");
                txtAccountType.Focus();
            }
            else if (txtCreditLimit.Text == "")
            {
                MessageBox.Show("Please Enter Credit Limit", "Error Message");
                txtCreditLimit.Focus();
            }            
            else if (txtBalance.Text == "")
            {
                MessageBox.Show("Please Enter Balance", "Error Message");
                txtBalance.Focus();
            }
            else if (cmbTranactionType.Text == "")
            {
                MessageBox.Show("Please Select Transaction Type", "Error Message");
                cmbTranactionType.Focus();
            }
            else if (cmbDocumentType.Text == "")
            {
                MessageBox.Show("Please Select Document Type", "Error Message");
                cmbDocumentType.Focus();
            }
            else if (txtDocumentNumber.Text== "")
            {
                MessageBox.Show("Please Document Numbert", "Error Message");
                txtDocumentNumber.Focus();
            }
            else if (txtAmount.Text == "")
            {
                MessageBox.Show("Please Enter Amount", "Error Message");
                txtAmount.Focus();
            }
            else if (txtTranactionDate.Text == "")
            {
                MessageBox.Show("Please Enter Tranaction Date", "Error Message");
                txtTranactionDate.Focus();
            }
            else
            {
                String strAmount,strPart;
                int ctr;
                strAmount = txtAmount.Text;
                for (ctr = 0; ctr < strAmount.Length; ctr++)
                {
                    strPart = strAmount.Substring(ctr, 1);
                    if (!char.IsDigit(Convert.ToChar(strPart)) && Convert.ToChar(strPart) != '.')
                    {
                        MessageBox.Show("Amount can contains Digits [0-9] and Dot only", "Error Message");
                        return;
                    }
                }
                double dbBalance;
                dbBalance = Convert.ToDouble(txtBalance.Text);

                double dbamount;
                dbamount = Convert.ToDouble(txtAmount.Text);

                double dbCreditLimit,dbTotalAmount;
                dbCreditLimit = Convert.ToDouble(txtCreditLimit.Text);

                dbTotalAmount = dbBalance + dbCreditLimit;

                DateTime dttran_date, dtCurrentDate;
                dttran_date = Convert.ToDateTime(txtTranactionDate.Text);
                dtCurrentDate = DateTime.Now;

                if (dbamount <= 0)
                {
                    MessageBox.Show("Amount should be greater than Zero", "Error Message");
                    txtAmount.Focus();
                }            
                else if (DateTime.Compare(dttran_date, dtCurrentDate)>0    )
                {
                    MessageBox.Show("Transaction Date cannot be greater than Current Date", "Error Message");
                    txtTranactionDate.Focus();
                }
                else
                {
                    String strTranType;
                    strTranType = cmbTranactionType.Text;
                    if (strTranType.Equals("Withdrwal"))
                    {
                        if (dbamount > dbTotalAmount)
                        {
                            MessageBox.Show("Withdrawl Amount is greater than Balance or Credit Limit", "Error Message");
                            txtAmount.Focus();
                            return;
                        }
                    }
                    String conStr = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
                    SqlConnection con = new SqlConnection();
                    try
                    {
                        con.ConnectionString = conStr;
                        con.Open();
                        String str = "insert TRANSACTIONS(TRAN_ID,ACNO,TRAN_TYPE,AMOUNT,DOC_TYPE,DOC_NUMBER,TRAN_DATE) values(@tranid,@acno,@tran_type,@amount,@doc_type,@doc_number,@tran_date)";
                        SqlCommand cmd = new SqlCommand(str, con);
                        cmd.CommandType = CommandType.Text;

                        SqlParameter sptranid;
                        sptranid = cmd.Parameters.Add("@tranid", SqlDbType.Char, 6);
                        sptranid.Value = cmbTranactionNo.Text;

                        SqlParameter spacno;
                        spacno = cmd.Parameters.Add("@acno", SqlDbType.Char, 6);
                        spacno.Value = cmbACNO.Text;

                        SqlParameter sptran_type;
                        sptran_type = cmd.Parameters.Add("@tran_type", SqlDbType.VarChar, 10);
                        sptran_type.Value = cmbTranactionType.Text;

                        SqlParameter spamount;
                        spamount = cmd.Parameters.Add("@amount", SqlDbType.Money);
                        spamount.Value = dbamount;

                        SqlParameter spdoc_type;
                        spdoc_type = cmd.Parameters.Add("@doc_type", SqlDbType.VarChar, 10);
                        spdoc_type.Value = cmbDocumentType.Text;

                        SqlParameter spdoc_number;
                        spdoc_number = cmd.Parameters.Add("@doc_number", SqlDbType.VarChar, 20);
                        spdoc_number.Value = txtDocumentNumber.Text;

                        SqlParameter sptran_date;
                        sptran_date = cmd.Parameters.Add("@tran_date", SqlDbType.DateTime);
                        sptran_date.Value = dttran_date;

                        cmd.ExecuteNonQuery();
                        cmbTranactionNo.Enabled = true;
                        cmdSave.Enabled = false;
                        cmdCancel.Enabled = false;
                        cmbTranactionNo.Enabled = true;

                        MessageBox.Show("Record has been Saved", "Message");
                    }
                    catch (Exception e1)
                    {
                       String strMessage = "Violation of UNIQUE KEY constraint 'cons_doctype_docnumber'."; 
                       if (e1.Message.Substring(0,60).Equals(strMessage))
                        {
                            MessageBox.Show("Combination of Document Type and Document Number already Exists", "Error Message");
                            txtDocumentNumber.Text = "";
                            cmbDocumentType.Focus();
                            return;
                        }
                    }
                    //////////////////////////////////////////////////////////////////

                    String str2 = "SELECT TRAN_ID FROM TRANSACTIONS";
                    SqlCommand cmd2 = new SqlCommand(str2, con);
                    cmd2.CommandType = CommandType.Text;

                    SqlDataReader reader2;
                    reader2 = cmd2.ExecuteReader();
                    cmbTranactionNo.Items.Clear();
                    if (reader2.HasRows == true)
                    {
                        while (reader2.Read())
                        {
                            cmbTranactionNo.Items.Add(Convert.ToString(reader2["TRAN_ID"]));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Record did not Find in TRANSACTIONS Table", "Error Message");
                    }
                    con.Close();
                    //////////////////////////////////////////////////////////////////
                    String conStr3 = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
                    SqlConnection con3 = new SqlConnection();
                    con3.ConnectionString = conStr3;
                    con3.Open();
                    String str3 = "UPDATE ACCOUNTS SET BALANCE=@balance2 WHERE ACNO=@acno2";
                    SqlCommand cmd3 = new SqlCommand(str3, con3);
                    cmd3.CommandType = CommandType.Text;

                 
                    if (strTranType.Equals("Deposit"))
                     {
                         dbBalance = dbBalance + dbamount;
                     }
                     if (strTranType.Equals("Withdrwal"))
                     {
                         dbBalance = dbBalance - dbamount;
                     } 
                    SqlParameter spbalance;
                    spbalance = cmd3.Parameters.Add("@balance2", SqlDbType.Money);
                    spbalance.Value = dbBalance;

                    SqlParameter spacno2;
                    spacno2 = cmd3.Parameters.Add("@acno2", SqlDbType.Char, 6);
                    spacno2.Value = cmbACNO.Text;

                    cmd3.ExecuteNonQuery();
                    con3.Close();
                    MessageBox.Show("Record has been Udated", "Message");
                }
            }
        }
       

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (cmbTranactionNo.Text == "")
            {
                MessageBox.Show("Please Select Tranaction Number", "Error Message");
                cmbTranactionNo.Focus();
            }
            else
            {
                String conStr = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conStr;
                con.Open();
                String str = "DELETE TRANSACTIONS WHERE TRAN_ID=@tranid";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.Text;
                
                SqlParameter sptranid;
                sptranid = cmd.Parameters.Add("@tranid", SqlDbType.Char, 6);
                sptranid.Value = cmbTranactionNo.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record has been Deleted", "Error Message");

                String str2 = "SELECT * FROM TRANSACTIONS";
                SqlCommand cmd2 = new SqlCommand(str2, con);
                cmd2.CommandType = CommandType.Text;
                SqlDataReader reader2;
                reader2 = cmd2.ExecuteReader();
                reader2.Read();
                if (reader2.HasRows == true)
                {
                    cmbTranactionNo.Text = Convert.ToString(reader2["TRAN_ID"]);
                    cmbACNO.Text = Convert.ToString(reader2["ACNO"]);
                    cmbTranactionType.Text = Convert.ToString(reader2["TRAN_TYPE"]);
                    txtAmount.Text = Convert.ToString(reader2["AMOUNT"]);
                    cmbDocumentType.Text = Convert.ToString(reader2["DOC_TYPE"]);
                    txtDocumentNumber.Text = Convert.ToString(reader2["DOC_NUMBER"]);
                    txtTranactionDate.Text = Convert.ToString(reader2["TRAN_DATE"]);
                }
                else
                {
                    cmbTranactionNo.Text = "";
                    cmbACNO.SelectedIndex = -1; ;
                    txtAccountType.Text = "";
                    txtCreditLimit.Text = "";
                    txtBalance.Text = "";
                    cmbTranactionType.SelectedIndex = -1;
                    txtAmount.Text = "";
                    cmbDocumentType.SelectedIndex = -1;
                    txtDocumentNumber.Text = "";
                    txtTranactionDate.Text = "";
                    cmdSave.Enabled = true;
                    cmdCancel.Enabled = true;
                    cmbTranactionNo.Enabled = false;
                    MessageBox.Show("Record did not Find", "Error Message");
                }
                con.Close();

                ////////////////////////////////////////////////////////////
                String conStr3 = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
                SqlConnection con3 = new SqlConnection();
                con3.ConnectionString = conStr3;
                con3.Open();

                String str3 = "SELECT TRAN_ID FROM TRANSACTIONS";
                SqlCommand cmd3 = new SqlCommand(str3, con3);
                cmd3.CommandType = CommandType.Text;

                SqlDataReader reader3;
                reader3 = cmd3.ExecuteReader();
                cmbTranactionNo.Items.Clear();
                if (reader3.HasRows == true)
                {
                    while (reader3.Read())
                    {
                        cmbTranactionNo.Items.Add(Convert.ToString(reader3["TRAN_ID"]));
                    }
                }
                else
                {
                    MessageBox.Show("Record did not Find in TRANSACTIONS Table", "Error Message");
                }
                con3.Close();
            }
        }

        private void cmbTranactionNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTranactionNo.Text == "")
            {
                MessageBox.Show("Please Select Tranaction Number", "Error Message");
                cmbTranactionNo.Focus();
            }
            else
            {
                String conStr = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conStr;
                con.Open();
                String str = "SELECT * FROM TRANSACTIONS WHERE TRAN_ID=@tranid";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.Text;

                SqlParameter sptranid;
                sptranid = cmd.Parameters.Add("@tranid", SqlDbType.Char, 6);
                sptranid.Value = cmbTranactionNo.Text;

                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows == true)
                {
                    cmbTranactionNo.Text = Convert.ToString(reader["TRAN_ID"]);
                    cmbACNO.Text = Convert.ToString(reader["ACNO"]);
                    cmbTranactionType.Text = Convert.ToString(reader["TRAN_TYPE"]);
                    txtAmount.Text = Convert.ToString(reader["AMOUNT"]);
                    cmbDocumentType.Text = Convert.ToString(reader["DOC_TYPE"]);
                    txtDocumentNumber.Text = Convert.ToString(reader["DOC_NUMBER"]);
                    txtTranactionDate.Text = Convert.ToString(reader["TRAN_DATE"]);
                }
                else
                {
                    MessageBox.Show("Record did not Find", "Error Message");
                }
            }
        }

        private void cmdTransactionsDetails_Click(object sender, EventArgs e)
        {
            String conStr = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conStr;
            con.Open();
            String str = "SELECT * FROM TRANSACTIONS";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            //reader.Read();
            if (reader.HasRows == true)
            {
                dgvAccountDetails.DataSource = null;
                DataTable datatable1 = new DataTable();
                datatable1.Load(reader);
                dgvAccountDetails.DataSource = datatable1;
               con.Close();                     
            }
            else
            {
                MessageBox.Show("Records did not Find", "Error Message");
            }
        }

        private void cmdacTransactionsDetails_Click(object sender, EventArgs e)
        {
            if (cmbACNO.SelectedIndex != -1)
            {
                if (cmbACNO.Text == "")
                {
                    MessageBox.Show("Please Enter Account Number", "Error Message");
                    cmbACNO.Focus();
                }
                else
                {
                    String conStr2 = "Data Source=INDIA;Initial Catalog=SBIBank;User ID=sa;password=rgpg007";
                    SqlConnection con2 = new SqlConnection();
                    con2.ConnectionString = conStr2;
                    con2.Open();
                    String str2 = "SELECT ACNO,TRAN_ID,TRAN_TYPE,AMOUNT,DOC_TYPE,DOC_NUMBER,TRAN_DATE FROM TRANSACTIONS WHERE ACNO=@acno";
                    SqlCommand cmd2 = new SqlCommand(str2, con2);
                    cmd2.CommandType = CommandType.Text;

                    SqlParameter spacno2;
                    spacno2 = cmd2.Parameters.Add("@acno", SqlDbType.Char, 6);
                    spacno2.Value = cmbACNO.Text;

                    SqlDataReader reader2;
                    reader2 = cmd2.ExecuteReader();
                    if (reader2.HasRows == true)
                    {
                        dgvAccountDetails.DataSource = null;
                        DataTable datatable1 = new DataTable();
                        datatable1.Load(reader2);
                        dgvAccountDetails.DataSource = datatable1;

                    }
                    else
                    {
                        MessageBox.Show("Record did not Find", "Error Message");
                    }
                    con2.Close();
                }
            }
        } 
    }
}