using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnIntegerArray_Click(object sender, EventArgs e)
        {

            int []arrAccountNo = new int[4];
            arrAccountNo[0] = 101;
            arrAccountNo[1] = 102;
            arrAccountNo[2] = 103;
            arrAccountNo[3] = 104;

            MessageBox.Show("Account Number1 : " + arrAccountNo[0]);
            MessageBox.Show("Account Number2 : " + arrAccountNo[1]);
            MessageBox.Show("Account Number3 : " + arrAccountNo[2]);
            MessageBox.Show("Account Number4 : " + arrAccountNo[3]);
        }

        private void btnStringArray_Click(object sender, EventArgs e)
        {
            String[] strName = new String[4];
            strName[0] = "Bill Gates";
            strName[1] = "Mark Jukerberg";
            strName[2] = "Shiv Nadar";
            strName[3] = "Sameep Bhatia";

            MessageBox.Show("Name1 : " + strName[0]);
            MessageBox.Show("Name2 : " + strName[1]);
            MessageBox.Show("Name3 : " + strName[2]);
            MessageBox.Show("Name4 : " + strName[3]);
        }

        private void btnFloatArray_Click(object sender, EventArgs e)
        {
            float[] arrBalance = new float[4];
            arrBalance[0] = 6754.22F;
            arrBalance[1] = 533.7F;
            arrBalance[2] = 455.78F;
            arrBalance[3] = 7.4F;

            MessageBox.Show("Balance1 : " + arrBalance[0]);
            MessageBox.Show("Balance2 : " + arrBalance[1]);
            MessageBox.Show("Balance3 : " + arrBalance[2]);
            MessageBox.Show("Balance4 : " + arrBalance[3]);
        }

       
    }
}
