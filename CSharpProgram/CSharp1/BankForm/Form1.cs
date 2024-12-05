using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int acno;
            String strFirstName, strLastName, strAddress, strDOB, strOpeningDate;
            Acno=Convert.ToInt32(txtAcno.Text);
            strFirstName = txtFirstName.Text;
            strLastName = txtLastName.Text;
            strAddress = txtAddress.Text;
            strDOB = dtpDOB.Text;
            strOpeningDate = dtpOpeningDate.Text;
        }
        MessageBox.Show("Account no is:"+Acno+"\nFirst name is:"+strFirstName+"\n Last Name is:"+strLastName+"\n Address is:"+strAddress+"\n Date of Birth is:"+strDOB+ "\n Opening Date is :" +strOpeningDate);

        }
    }
}
