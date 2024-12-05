using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp160716_E2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chkMusic.CheckState.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chkPainting.Checked = true;
        }

        private void btnUserChoice_Click(object sender, EventArgs e)
        {
            String str="";
            if (chkSports.Checked == true)
                str = str + "Sports\n";
            if (chkPainting.Checked == true)
                str = str + "Painting\n";
            if (chkReading.Checked == true)
                str = str + "Reading\n";
            if (chkMusic.Checked == true)
                str = str + "Music\n";
            if (chkSinging.Checked == true)
                str = str + "Singing\n";
            if (chkChatting.Checked == true)
                str = str + "Chatting\n";

            MessageBox.Show(str, "User Choice");
        }

        private void btnCancelUserChoice_Click(object sender, EventArgs e)
        {
            chkSports.Checked=false;
            chkPainting.Checked = false;
            chkReading.Checked = false;
            chkMusic.Checked = false;
            chkSinging.Checked = false;
            chkChatting.Checked = false;
        }
    }
}
