using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeReport
{
    public partial class frmEmployee : Form
    {
        System.IO.StreamReader SR;
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            WriteFile();//calling WriteFile method
            //For printing the file contents
            printDocument1.DocumentName = "c:\\test\\MyData.txt";
            DialogResult res = printDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                printDocument1.Print();
                SR.Close();
            }

        }

        //Method for creating a text file for the employee's data
        private void WriteFile()
        {
            string str;
            System.IO.StreamWriter SW = new System.IO.StreamWriter("c:\\test\\MyData.txt", false);
            SW.WriteLine("Name: " + txtName.Text);
            SW.WriteLine("Designation: " + txtDesig.Text);
            str = Convert.ToString(dtpDOB.Value);
            SW.WriteLine("DOB: " + str.Substring(0, 10));
            SW.WriteLine("Experience: " + txtExperience.Text);
            SW.WriteLine("Address: " + txtAddress.Text);
            SW.WriteLine("Contact No: " + txtContactNo.Text);
            SW.WriteLine("Qualification: " + txtQuali.Text);
            SW.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //For reading the text file
            SR=new System.IO.StreamReader("C:\\test\\MyData.txt",true);
            string str = SR.ReadToEnd();
            e.Graphics.DrawString(str, new Font("Times New Roman",1), Brushes.Black, 150, 125);
        }
    }
}