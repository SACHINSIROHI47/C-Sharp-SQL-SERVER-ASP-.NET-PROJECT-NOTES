using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp16062016
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnFacilities_Click(object sender, EventArgs e)
        {
            String strDebitCard,strCreditCard,strOnlineBanking;
            strDebitCard=" ";
            strCreditCard= " ";
            strOnlineBanking = " ";
            if (chkDebitCard.Checked == true)
            {
                strDebitCard = "DebitCard";
            }
            if (chkCreditCard.Checked == true)
            {
                strCreditCard = "CreditCard";
            }
            if(chkOnlineBanking.Checked==true)
            {
                strOnlineBanking ="OnlineBanking";
            }
            MessageBox.Show("Facilities \n" + strDebitCard + "\n" + strCreditCard + "\n" + strOnlineBanking);
            lblFacilities.Text = "Facilities \n" + strDebitCard + "\n" + strCreditCard + "\n" + strOnlineBanking;      
        
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your City : " + cmbCity.Text);
        }
    }
}
