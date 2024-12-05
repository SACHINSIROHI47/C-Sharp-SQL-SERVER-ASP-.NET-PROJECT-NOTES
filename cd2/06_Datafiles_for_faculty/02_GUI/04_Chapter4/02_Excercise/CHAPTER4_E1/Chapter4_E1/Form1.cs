using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lesson_Ex1
{
    public partial class frmPAN : Form
    {
        public frmPAN()
        {
            InitializeComponent();
        }

        //This function is used to Check the validations and display the appropriate errors.
        private bool CheckValidation()
        {
            bool flag = true;
            if (txtEmpName.Text  == "")
            {
                errorProvider1.SetError(txtEmpName, "Please Fill In The Name.");
                txtEmpName.Focus();
                flag = false;
            }
            if (txtEmpCode.Text  == "")
            {
                errorProvider1.SetError(txtEmpCode, "Please Fill In The SSN Number.");
                txtEmpCode.Focus();
                flag = false;
            }
            if (txtAdd.Text   == "")
            {
                errorProvider1.SetError(txtAdd, "Please Fill In The Address.");
                txtAdd.Focus();
                flag = false;
            }
            if (dtDOJ.Value  < DateTime.Now)
            {
                errorProvider1.SetError(dtDOJ , "Please Fill In The Correct Date of Applying.");
                txtAdd.Focus();
                flag = false;
            }
            return flag;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //the return value of the CheckValidation() function is used to display the message.
            if (CheckValidation())
            {
                errorProvider1.Clear();
                MessageBox.Show("Submitted, You Will Get Your Passport WithIn 15 Working Days.");
                tssLabel.Text = "";

            }
            else
            {
                MessageBox.Show("Please Fill The Correct Entries.");
            }
        }

        private void frmPAN_Load(object sender, EventArgs e)
        {

        }

        //Enter event is used to display a message on the StatusStrip
        private void txtEmpName_Enter(object sender, EventArgs e)
        {
            tssLabel.Text = "Please Enter Your Name.";
        }

        private void txtEmpCode_Enter(object sender, EventArgs e)
        {
            tssLabel.Text = "Please Enter The SSN Number. It Should Be Numeric";
        }

        private void txtAdd_Enter(object sender, EventArgs e)
        {
            tssLabel.Text = "Please Enter Permanent Address.";
        }

        private void dtDOJ_Enter(object sender, EventArgs e)
        {
            tssLabel.Text = "Please Enter The Date of Applying. It Could Not Be Prior To The Current Date.";
        }

        //For allowing only numeric values in the txtEmpCode Text Box
        private void txtEmpCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar < 58 || e.KeyChar==127 ||e.KeyChar==8)
            {
               
            }
            else
            {
                e.KeyChar =Convert.ToChar(0);
            }
        }

        private void dtDOJ_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}