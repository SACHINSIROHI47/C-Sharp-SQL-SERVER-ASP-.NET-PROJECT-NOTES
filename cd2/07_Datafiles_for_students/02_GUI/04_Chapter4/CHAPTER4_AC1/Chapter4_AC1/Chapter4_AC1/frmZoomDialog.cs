using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chapter4_AC1
{
    public partial class frmZoomDialog : Form
    {
        public frmZoomDialog()
        {
            InitializeComponent();
        }
        private int _zoomText;
        // Create ZoomFactor property.
        public int ZoomText
        {
            get
            {
                return _zoomText;
            }
            set
            {
                _zoomText= value;
            }
        }
        

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.ZoomText = (int)numericUpDownZoom.Value;
        }

        

       
    }
}