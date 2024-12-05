using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BANKING
{
    public partial class frmMenu : Form
    {
        //Boolean blnFlag;      
        public frmMenu()
        {
            InitializeComponent();
        }

        private void menuAccount_Click(object sender, EventArgs e)
        {
            frmAccount obj = new frmAccount();
            obj.Show();
            obj.MdiParent = this;

          /* foreach (Form frm in this.MdiChildren)
            {                 
                if (frm.Name.Equals("frmAccount"))
                {
                    blnFlag = true;
                    break;                        
                }
            }
            if (blnFlag == false)
            {
                frmAccount obj = new frmAccount();
                obj.Show();
                obj.MdiParent = this;
            }*/             
        }

        private void MenuTransaction_Click(object sender, EventArgs e)
        {
            frmTRANSACTIONS obj = new frmTRANSACTIONS();
            obj.Show();
            obj.MdiParent = this;

            /*blnFlag = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals("frmTRANSACTIONS"))
                {
                    blnFlag = true;
                    break;
                }
            }
            if (blnFlag == false)
            {
                frmTRANSACTIONS obj = new frmTRANSACTIONS();
                obj.Show();
                obj.MdiParent = this;
            }*/           
           
        }
            
      
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnuAccountDetails_Click(object sender, EventArgs e)
        {
            frmAccountReport obj = new frmAccountReport();
             obj.Show();
             obj.MdiParent = this;            
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnutransactionDetails_Click(object sender, EventArgs e)
        {
            frmTransactionReport obj = new frmTransactionReport();
            obj.Show();
            obj.MdiParent = this;           
        }

      

       

       
    }
}