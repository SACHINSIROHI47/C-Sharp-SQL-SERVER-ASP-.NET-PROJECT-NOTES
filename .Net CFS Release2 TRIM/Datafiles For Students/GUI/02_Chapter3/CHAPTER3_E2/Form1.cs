using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chapter3_AC3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(treeViewItems.SelectedNode.Text);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            lbDestinationItem.Items.Add(Clipboard.GetData(DataFormats.Text));
            Clipboard.Clear();
        }
    }
}