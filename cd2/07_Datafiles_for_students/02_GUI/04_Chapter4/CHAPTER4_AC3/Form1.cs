using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chapter4_Ac2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuItemStudent_Click(object sender, EventArgs e)
        {
            //Create a new instance of frmStudent
            frmStudent stdFrmObj = new frmStudent();
            //Set the parent of the MDI child form
            stdFrmObj.MdiParent = this;
            //Display the new form
            stdFrmObj.Show();
        }

        private void menuItemFaculty_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Faculty Details Menu Item Clicked");
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStripItemStudent_Click(object sender, EventArgs e)
        {
            //Create a new instance of frmStudent
            frmStudent stdFrmObj = new frmStudent();
            //Set the parent of the MDI child form
            stdFrmObj.MdiParent = this;
            //Display the new form
            stdFrmObj.Show();
        }

        private void contextMenuStripItemFaculty_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Faculty Details Context Menu Item Clicked");
        }

        private void contextMenuStripItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}