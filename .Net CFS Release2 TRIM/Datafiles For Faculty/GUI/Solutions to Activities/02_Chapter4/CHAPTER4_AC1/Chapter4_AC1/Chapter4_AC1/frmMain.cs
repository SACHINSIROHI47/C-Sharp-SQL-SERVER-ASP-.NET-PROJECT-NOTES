using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chapter4_AC1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            frmZoomDialog zdFrmObj = new frmZoomDialog();
            DialogResult dResult=zdFrmObj.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                richTextBox1.ZoomFactor = zdFrmObj.ZoomText;
            }

        }
    }
}