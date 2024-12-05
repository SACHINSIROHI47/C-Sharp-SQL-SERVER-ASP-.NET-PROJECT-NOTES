using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lesson5_AC1
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        //Function for validating the input data and displaying the appropriate error.
        private int ValidateData()
        {
            int flag=0;
            if (txtFName.Text == "")
            {
                txtFName.Focus();
                errorProvider1.SetError(txtFName, "Please Fill In The First Name");
                flag = 1;
            }
            if (txtLName.Text == "")
            {
                txtLName.Focus();
                errorProvider1.SetError(txtLName, "Please Fill In The Last Name");
                flag = 1;
            }
            if (dtpDOJ.Value > DateTime.Now)
            {
                dtpDOJ.Focus();
                errorProvider1.SetError(dtpDOJ, "Please Fill The Correct Date of Joining");
                flag = 1;
            }
            if (txtAddress.Text == "")
            {
                txtAddress.Focus();
                errorProvider1.SetError(txtAddress, "Please Fill In The Address");
                flag = 1;
            }
            if (txtQuali.Text == "")
            {
                txtQuali.Focus();
                errorProvider1.SetError(txtQuali, "Please Fill In The Qualification");
                flag = 1;
            }
            return flag;
        }

        //Cheking the return value of the ValidateData() function to display the appropriate result.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {
                errorProvider1.Clear();
                MessageBox.Show("Submitted");
                tssWarning.Text = "";
            }
            else 
            {
                MessageBox.Show("Correct The Error(s)");
            }

        }

        //code to display the message on the StatusStrip control.
        private void txtFName_Enter(object sender, EventArgs e)
        {
            tssWarning.Text = "Please Enter Your First Name";
        }

        private void txtLName_Enter(object sender, EventArgs e)
        {
            tssWarning.Text = "Please Enter Your Last Name";
        }

        private void dtpDOB_Enter(object sender, EventArgs e)
        {
            tssWarning.Text = "Please Enter Your DOJ. It Must Be Earlier Than The Present Date";
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            tssWarning.Text = "Please Enter Your Address";
        }

        private void txtQuali_Enter(object sender, EventArgs e)
        {
            tssWarning.Text = "Please Enter Your Qualification";
        }

        private void btnSubmit_Enter(object sender, EventArgs e)
        {
            tssWarning.Text = "";
        }
    }
}