using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomizePrinting
{
    public partial class frmPrint : Form
    {
        private CustomDocument Doc = new CustomDocument();
        
        public frmPrint()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Set initial properties of the openFileDialog.
            openFileDialog1.InitialDirectory = "E:\\Labfiles\\Starter";
            openFileDialog1.FileName = "";
            // Show the dialog.
            DialogResult result = openFileDialog1.ShowDialog(this);
            // If user clicked ok, display file name and path in text box on form.
            if (result == DialogResult.OK)
            {
                txtFileToPrint.Text = openFileDialog1.FileName.ToString();
            }

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            // If the FileToPrintTextBox is not empty:
            if (txtFileToPrint.Text != "")
            {
                //  Set properties of the CustomPrintDocument object
                // Using the values selected on the Printing form.
                Doc.FileToPrint = txtFileToPrint.Text;
                Doc.PrintFont = new Font(cmbFonts.Text, 10);
                Doc.DocumentName = txtHeader.Text;
                // Set the headerheight property.
                Doc.HeaderHeight = 100;
                // Specify the print document for the PrintPreviewDialog.
                printPreviewDialog1.Document = Doc;
                // Open the PrintPreviewDialog.
                printPreviewDialog1.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Please select the file to be printed.", "File not selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFileToPrint.Focus();
            }

        }

        private void frmPrint_Load(object sender, EventArgs e)
        {

        }
    }
}