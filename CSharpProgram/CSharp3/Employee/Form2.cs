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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDayName_Click(object sender, EventArgs e)
        {
            int intDayNo;
            intDayNo = Convert.ToInt32(txtDayNo.Text);
                if (intDayNo == 1)
                {
                    lblDayName.Text = "Sunday";
                    MessageBox.Show("Sunday");
                }
                else if (intDayNo == 2)
                {
                    lblDayName.Text = "Monday";
                    MessageBox.Show("Monday");
                }
                else if (intDayNo == 3)
                {
                    lblDayName.Text = "Tuesday";
                    MessageBox.Show("Tuesday");
                }
                else if (intDayNo == 4)
                {
                    lblDayName.Text = "Wednesday";
                    MessageBox.Show("Wednesday");
                }
                else if (intDayNo == 5)
                {
                    lblDayName.Text = "Thrusday";
                    MessageBox.Show("Thrusday");
                }
                else if (intDayNo == 6)
                {
                    lblDayName.Text = "Friday";
                    MessageBox.Show("Friday");
                }
                else if (intDayNo == 7)
                {
                    lblDayName.Text = "Saturday";
                    MessageBox.Show("Saturday");
                }
                else
                {
                    lblDayName.Text = "Invalid day";
                    MessageBox.Show("Invalid day");
                }
            
            
        }

        private void btnDayName2_Click(object sender, EventArgs e)
        {
            int intDayNo;
            if (txtDayNo.Text.Length == 0)
            {
                lblDayName.Text = "Enter Day Number";
                MessageBox.Show("Enter Day Number");
            }
            else
            {
                intDayNo = Convert.ToInt32(txtDayNo.Text);
                if (intDayNo == 1)
                {
                    lblDayName.Text = "Sunday";
                    MessageBox.Show("Sunday");
                }
                else if (intDayNo == 2)
                {
                    lblDayName.Text = "Monday";
                    MessageBox.Show("Monday");
                }
                else if (intDayNo == 3)
                {
                    lblDayName.Text = "Tuesday";
                    MessageBox.Show("Tuesday");
                }
                else if (intDayNo == 4)
                {
                    lblDayName.Text = "Wednesday";
                    MessageBox.Show("Wednesday");
                }
                else if (intDayNo == 5)
                {
                    lblDayName.Text = "Thrusday";
                    MessageBox.Show("Thrusday");
                }
                else if (intDayNo == 6)
                {
                    lblDayName.Text = "Friday";
                    MessageBox.Show("Friday");
                }
                else if (intDayNo == 7)
                {
                    lblDayName.Text = "Saturday";
                    MessageBox.Show("Saturday");
                }
                else
                {
                    lblDayName.Text = "Invalid day";
                    MessageBox.Show("Invalid day");
                }
            }
        }
    }
}
