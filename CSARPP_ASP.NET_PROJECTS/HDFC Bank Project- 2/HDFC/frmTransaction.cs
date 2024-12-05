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
    public partial class txt : Form
    {
        public txt()
        {
            InitializeComponent();
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            cmbTransactionType.Items.Add("Deposit");
            cmbTransactionType.Items.Add("Withdrawl");

            cmbDocumentType.Items.Add("Cash");
            cmbDocumentType.Items.Add("Cheque");
            try
            {
                //To add Account Number in ComboBox from Account Table
                String conStr = "Data Source=RGPG-COMPUTER1;Initial Catalog=HDFCBank;User Id=sa;Password=sqlserver";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conStr;
                con.Open();

                String str = "SELECT ACNO FROM ACCOUNTS";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                cmbAccountNumber.Items.Clear();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        cmbAccountNumber.Items.Add(Convert.ToString(reader["ACNO"]));
                    }
                }
                else
                {
                    MessageBox.Show("Record did not Find in ACCOUNTS Table", "Error Message");
                }
                reader.Close();

                //To add Tranaction Number in ComboBox from Tranaction Table
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
                con.Close();
            }
            catch (Exception obj)
            {
                MessageBox.Show("Exception : " + obj.Message.ToString());
            }
        }

        private void cmbAccountNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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

                        txtFirstName.Text = Convert.ToString(reader["FIRST_NAME"]);
                        txtLastName.Text = Convert.ToString(reader["LAST_NAME"]);
                        txtBalance.Text = Convert.ToString(reader["BALANCE"]);
                        pictureBox1.ImageLocation = Convert.ToString(reader["AC_IMAGE"]);
                    }
                    else
                    {
                        MessageBox.Show("Record did not Find", "Error Message");

                    }

                    reader.Close();
                    //Display TRANSACTIONS Table Record in GridView Control

                    String str2 = "SELECT * FROM TRANSACTIONS WHERE ACNO=@acno";
                    SqlCommand cmd2 = new SqlCommand(str2, con);
                    cmd2.CommandType = CommandType.Text;

                    SqlParameter spacno2;
                    spacno2 = cmd2.Parameters.Add("@acno", SqlDbType.Char, 6);
                    spacno2.Value = cmbAccountNumber.Text;

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
                    con.Close();

                }
            }
            catch (Exception obj)
            {
                MessageBox.Show("Exception : " + obj.Message.ToString());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                //Generate New Transaction Numner
                String conStr = "Data Source=RGPG-COMPUTER1;Initial Catalog=HDFCBank;User Id=sa;Password=sqlserver";
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

            }
            catch (Exception obj)
            {
                MessageBox.Show("Exception : " + obj.Message.ToString());
            }
            cmbAccountNumber.SelectedIndex = -1; ;
            txtBalance.Text = "";
            cmbTransactionType.SelectedIndex = -1;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAmount.Text = "";
            cmbDocumentType.SelectedIndex = -1;
            txtDocumentNumber.Text = "";
            dtpTransactionDate.Text = "";
            pictureBox1.ImageLocation = null;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbTranactionNo.Text == "")
            {
                MessageBox.Show("Please Enter Tranaction Number", "Error Message");
                cmbTranactionNo.Focus();
            }
            else if (cmbAccountNumber.Text == "")
            {
                MessageBox.Show("Please Select Account Number", "Error Message");
                cmbAccountNumber.Focus();
            }
            else if (txtBalance.Text == "")
            {
                MessageBox.Show("Please Enter Balance", "Error Message");
                txtBalance.Focus();
            }
            else if (cmbTransactionType.Text == "")
            {
                MessageBox.Show("Please Select Transaction Type", "Error Message");
                cmbTransactionType.Focus();
            }
            else if (cmbDocumentType.Text == "")
            {
                MessageBox.Show("Please Select Document Type", "Error Message");
                cmbDocumentType.Focus();
            }
            else if (txtDocumentNumber.Text == "")
            {
                MessageBox.Show("Please Enter Document Number", "Error Message");
                txtDocumentNumber.Focus();
            }
            else if (txtAmount.Text == "")
            {
                MessageBox.Show("Please Enter Amount", "Error Message");
                txtAmount.Focus();
            }
            else if (dtpTransactionDate.Text == "")
            {
                MessageBox.Show("Please Enter Tranaction Date", "Error Message");
                dtpTransactionDate.Focus();
            }
            else
            {
                String strAmount, strPart;
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

                DateTime dttran_date, dtCurrentDate;
                dttran_date = Convert.ToDateTime(dtpTransactionDate.Text);
                dtCurrentDate = DateTime.Now;

                if (dbamount <= 0)
                {
                    MessageBox.Show("Amount should be greater than Zero", "Error Message");
                    txtAmount.Focus();
                }
                else if (DateTime.Compare(dttran_date, dtCurrentDate) > 0)
                {
                    MessageBox.Show("Transaction Date cannot be greater than Current Date", "Error Message");
                    dtpTransactionDate.Focus();
                }
                else
                {
                    String strTranType;
                    strTranType = cmbTransactionType.Text;
                    if (strTranType.Equals("Withdrawl"))
                    {
                        if (dbamount > dbBalance)
                        {
                            MessageBox.Show("Withdrawl Amount is greater than Balance", "Error Message");
                            txtAmount.Focus();
                            return;
                        }
                        else
                        {
                            dbBalance = dbBalance - dbamount;
                        }
                    }
                    

                    String conStr = "Data Source=RGPG-COMPUTER1;Initial Catalog=HDFCBank;User Id=sa;Password=sqlserver";
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
                        spacno.Value = cmbAccountNumber.Text;

                        SqlParameter sptran_type;
                        sptran_type = cmd.Parameters.Add("@tran_type", SqlDbType.VarChar, 10);
                        sptran_type.Value = cmbTransactionType.Text;

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

                        MessageBox.Show("Record has been Saved  in Transaction Table", "Message");
                    }
                    catch (Exception e1)
                    {
                        String strMessage = "Violation of UNIQUE KEY constraint 'cons_doctype_docnumber'.";
                        if (e1.Message.Substring(0, 60).Equals(strMessage))
                        {
                            MessageBox.Show("Combination of Document Type and Document Number already Exists", "Error Message");
                            txtDocumentNumber.Text = "";
                            cmbDocumentType.Focus();
                            return;
                        }
                        MessageBox.Show("Exception : " + e1.Message.ToString());
                        return;
                    }
                    //////////////////////////////////////////////////////////////////
                    try
                    {
                        String str2 = "SELECT TRAN_ID FROM TRANSACTIONS ORDER BY TRAN_ID ASC";
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
                        /////////Update Account Balance
                        String conStr3 = "Data Source=RGPG-COMPUTER1;Initial Catalog=HDFCBank;User Id=sa;Password=sqlserver";
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
                        spacno2.Value = cmbAccountNumber.Text;

                        cmd3.ExecuteNonQuery();
                        con3.Close();
                        MessageBox.Show("Record has been Udated in Account Table", "Message");

                    }
                    catch (Exception obj)
                    {
                        MessageBox.Show("Exception : " + obj.Message.ToString());
                    }

                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }
    }
}

  

        
  
