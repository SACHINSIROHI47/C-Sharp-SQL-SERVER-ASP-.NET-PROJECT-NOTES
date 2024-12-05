using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BANKING
{
    public partial class frmWelcome : Form
    {
        String strMessage = "Welcome to State Bank of India.      ";     
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String strMessagePart1, strMessagePart2;
            strMessagePart1 = strMessage.Substring(0,1);
            strMessagePart2 = strMessage.Substring(1);
            strMessage = strMessagePart2 + strMessagePart1;
            lblMessage.Text = strMessage;         
            
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
           
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}