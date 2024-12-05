using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chapter4_E1
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            string Gender = "";
            string Course = "";
            string TimeSlot = "";
            string Facilities = "";
            if (txtName.Text == "" || txtAge.Text == "" || txtAddress.Text == "" || cmbCourse.Text == "")
                MessageBox.Show("Please enter all details");
            else
            {
                if (rbMale.Checked)
                    Gender = "Male";
                else if (rbFemale.Checked)
                    Gender = "Female";

                Course = cmbCourse.SelectedItem.ToString();
                TimeSlot = lstTimeSlot.SelectedItem.ToString();

                if (cbLibrary.Checked)
                {
                    Facilities = Facilities + " Library";
                }
                if (cbCompDrome.Checked)
                {
                    Facilities = Facilities + " Computer";
                }
                MessageBox.Show("Name: " + txtName.Text + "\nAge: " + txtAge.Text + "\nAddress: " + txtAddress.Text + "\nGender: " + Gender + "\nCourse: " + Course + "\nTime slot: " + TimeSlot + "\nFacilities : " + Facilities );
                txtName.Text = "";
                txtAge.Text = "";
                txtAddress.Text = "";
                rbMale.Checked = false;
                rbFemale.Checked = false;
                cbLibrary.Checked = false;
                cbCompDrome.Checked = false;
                cmbCourse.Text = "";
                lstTimeSlot.SelectedIndex = 0;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        
        private void vScrollBarAge_Scroll(object sender, ScrollEventArgs e)
        {
            txtAge.Text = vScrollBarAge.Value.ToString();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            studentDetailsChildFrmMenuItem.MergeAction = MergeAction.MatchOnly;

            cmbCourse.Items.Add("Web Application Developer");
            cmbCourse.Items.Add("Database Administrator");
            cmbCourse.Items.Add("Network Administrator");
            cmbCourse.Items.Add("Windows Application Developer");
            cmbCourse.SelectedIndex = 0;

            lstTimeSlot.Items.Add("7:00-9:00");
            lstTimeSlot.Items.Add("9:00-11:00");
            lstTimeSlot.Items.Add("11:00-1:00");
            lstTimeSlot.Items.Add("1:00-3:00");
            lstTimeSlot.Items.Add("3:00-5:00");
            lstTimeSlot.SelectedIndex = 0;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}