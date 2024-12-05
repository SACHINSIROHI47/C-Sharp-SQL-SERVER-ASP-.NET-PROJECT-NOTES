using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chapter4_E1
{
    public partial class frmFaculty : Form
    {
        public frmFaculty()
        {
            InitializeComponent();
        }
        private void studentFrm_Load(object sender, EventArgs e)
        {
            
           
            cmbCourse.Items.Add("Web Application Developer");
            cmbCourse.Items.Add("Database Administrator");
            cmbCourse.Items.Add("Network Administrator");
            cmbCourse.Items.Add("Windows Application Developer");
            cmbCourse.SelectedIndex = 0;

            qualificationLst.Items.Add("GNIIT/DNIIT");
            qualificationLst.Items.Add("MCA");
            qualificationLst.Items.Add("B.E.");
            qualificationLst.Items.Add("MCAD/MCSD");
            qualificationLst.Items.Add("CCNA");

            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string Gender = "";
            string Course = "";
            string Qualification = "";
            
            
            if (txtName.Text == "" || txtAge.Text == "" || txtAddress.Text == "" || cmbCourse.Text == "")
                MessageBox.Show("Please enter all details");
            else
            {
                if (rbMale.Checked)
                    Gender = "Male";
                else if (rbFemale.Checked)
                    Gender = "Female";

                Course = cmbCourse.SelectedItem.ToString();
                Qualification = qualificationLst.SelectedItem.ToString();
                
                MessageBox.Show("Name: " + txtName.Text + "\nAge: " + txtAge.Text + "\nAddress: " + txtAddress.Text + "\nGender: " + Gender + "\nCourse: " + Course + "\nQualification: " + Qualification);
                txtName.Text = "";
                txtAge.Text = "";
                txtAddress.Text = "";
                rbMale.Checked = false;
                rbFemale.Checked = false;
                cmbCourse.Text = "";
                qualificationLst.SelectedIndex = 0;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void agevScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            txtAge.Text = agevScrollBar.Value.ToString();
            
        }

       
    }
}