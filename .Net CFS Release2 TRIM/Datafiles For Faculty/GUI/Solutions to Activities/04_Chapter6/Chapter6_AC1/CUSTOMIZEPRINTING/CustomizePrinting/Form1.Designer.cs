namespace CustomizePrinting
{
    partial class frmPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrint));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblFont = new System.Windows.Forms.Label();
            this.cmbFonts = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.lblFileToPrint = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.txtFileToPrint = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(21, 60);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(61, 13);
            this.lblFont.TabIndex = 16;
            this.lblFont.Text = "Select Font";
            // 
            // cmbFonts
            // 
            this.cmbFonts.FormattingEnabled = true;
            this.cmbFonts.Items.AddRange(new object[] {
            "Arial",
            "Courier",
            "Book Antiqua",
            "Times New Roman",
            "Comic Sans MS"});
            this.cmbFonts.Location = new System.Drawing.Point(94, 57);
            this.cmbFonts.Name = "cmbFonts";
            this.cmbFonts.Size = new System.Drawing.Size(123, 21);
            this.cmbFonts.TabIndex = 15;
            this.cmbFonts.Text = "Arial";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(21, 97);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(69, 13);
            this.lblHeader.TabIndex = 14;
            this.lblHeader.Text = "Type Header";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(22, 113);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(260, 20);
            this.txtHeader.TabIndex = 11;
            // 
            // lblFileToPrint
            // 
            this.lblFileToPrint.AutoSize = true;
            this.lblFileToPrint.Location = new System.Drawing.Point(21, 9);
            this.lblFileToPrint.Name = "lblFileToPrint";
            this.lblFileToPrint.Size = new System.Drawing.Size(86, 13);
            this.lblFileToPrint.TabIndex = 13;
            this.lblFileToPrint.Text = "File to be Printed";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(142, 158);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 12;
            this.btnPreview.Text = "Preview...";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // txtFileToPrint
            // 
            this.txtFileToPrint.Location = new System.Drawing.Point(22, 25);
            this.txtFileToPrint.Name = "txtFileToPrint";
            this.txtFileToPrint.Size = new System.Drawing.Size(260, 20);
            this.txtFileToPrint.TabIndex = 9;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(288, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(66, 20);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 192);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.cmbFonts);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.txtHeader);
            this.Controls.Add(this.lblFileToPrint);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.txtFileToPrint);
            this.Controls.Add(this.btnBrowse);
            this.MaximizeBox = false;
            this.Name = "frmPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Helper";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.ComboBox cmbFonts;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.Label lblFileToPrint;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.TextBox txtFileToPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnBrowse;
    }
}

