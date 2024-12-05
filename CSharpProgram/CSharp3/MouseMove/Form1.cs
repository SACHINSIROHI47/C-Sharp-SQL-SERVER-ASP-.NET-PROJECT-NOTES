using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MouseMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
        private void btnOK_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnOK.BackColor = System.Drawing.Color.Azure;
        }


        
    }
}
