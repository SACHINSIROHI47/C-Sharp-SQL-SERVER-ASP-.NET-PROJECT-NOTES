using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chapter8_Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InterestCalculator calculatorObject;
            if (txtInterestType.Text == "Simple")
            {
                calculatorObject = new SimpleInterestCalculator();
                calculatorObject.calculateInterest();
            }
            else if (txtInterestType.Text == "Compound")
            {
                calculatorObject = new CompoundInterestCalculator();
                calculatorObject.calculateInterest();
            }
            else
                MessageBox.Show("Correct choices are : Simple or Compound");


        }
    }

    class SimpleInterestCalculator : InterestCalculator
    {
        #region InterestCalculator Members

        void InterestCalculator.calculateInterest()
        {
            MessageBox.Show("Will calculate Simple Interest");
        }

        #endregion
    }

    class CompoundInterestCalculator : InterestCalculator
    {
        #region InterestCalculator Members

        void InterestCalculator.calculateInterest()
        {
            MessageBox.Show("Will calculate Compound Interest");
        }

        #endregion
    }
}