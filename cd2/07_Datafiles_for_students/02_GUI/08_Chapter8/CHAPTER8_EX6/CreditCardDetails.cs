using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CValidator;

namespace Chapter8_Ex5
{
    public partial class CreditCardDetails : Form
    {
        public CreditCardDetails()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CardValidator Validator = new CardValidator();
            Validator.CardNumber = TextCard.Text;
            Validator.CustomerName = TextCustName.Text;
            Validator.Validate();
            if (Validator.Validate() == true)
                MessageBox.Show("Valid card Number");
            else
                MessageBox.Show("Invalid Card Number");

        }
    }
}