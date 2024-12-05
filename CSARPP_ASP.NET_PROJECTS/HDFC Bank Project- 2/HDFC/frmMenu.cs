using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HDFC
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show the form
            frmAccount obj1 = new frmAccount();
            obj1.Show();
            obj1.MdiParent = this;
        }

        private void transasctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show the form
            txt obj1 = new txt();
            obj1.Show();
            obj1.MdiParent = this;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close the Application
            Application.Exit();
        }
    }
}
