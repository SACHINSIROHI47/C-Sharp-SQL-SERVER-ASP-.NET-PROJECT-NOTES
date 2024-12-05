using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            else if (cmbAccountTypE.Text.Length == 0)
            {
                MessageBox.Show("Please Select Account Type", "Error Message");
                cmbAccountTypE.Focus();
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
                String strFirstName, strLastName, strState,strCity,strMobile,strBalance,strPart;
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

                MessageBox.Show("Record is Complete", "Message");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAccountTypE.Items.Add("Saving");
            cmbAccountTypE.Items.Add("Current");

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
