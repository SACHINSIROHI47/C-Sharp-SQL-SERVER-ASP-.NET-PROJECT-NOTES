namespace EmployeeReport
{
    partial class frmEmployee
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.lblExperience = new System.Windows.Forms.Label();
            this.txtQuali = new System.Windows.Forms.TextBox();
            this.lblQuali = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtDesig = new System.Windows.Forms.TextBox();
            this.lblDesig = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(171, 315);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(114, 27);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtExperience
            // 
            this.txtExperience.Location = new System.Drawing.Point(138, 99);
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Size = new System.Drawing.Size(55, 20);
            this.txtExperience.TabIndex = 18;
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(41, 99);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(82, 13);
            this.lblExperience.TabIndex = 27;
            this.lblExperience.Text = "Experience (yrs)";
            // 
            // txtQuali
            // 
            this.txtQuali.Location = new System.Drawing.Point(138, 223);
            this.txtQuali.Multiline = true;
            this.txtQuali.Name = "txtQuali";
            this.txtQuali.Size = new System.Drawing.Size(226, 69);
            this.txtQuali.TabIndex = 22;
            // 
            // lblQuali
            // 
            this.lblQuali.AutoSize = true;
            this.lblQuali.Location = new System.Drawing.Point(41, 223);
            this.lblQuali.Name = "lblQuali";
            this.lblQuali.Size = new System.Drawing.Size(65, 13);
            this.lblQuali.TabIndex = 26;
            this.lblQuali.Text = "Qualification";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(138, 197);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(226, 20);
            this.txtContactNo.TabIndex = 21;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(41, 197);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(61, 13);
            this.lblContactNo.TabIndex = 25;
            this.lblContactNo.Text = "Contact No";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(41, 122);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "Address";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(138, 122);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(226, 69);
            this.txtAddress.TabIndex = 19;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(138, 70);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 16;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(41, 70);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(30, 13);
            this.lblDOB.TabIndex = 20;
            this.lblDOB.Text = "DOB";
            // 
            // txtDesig
            // 
            this.txtDesig.Location = new System.Drawing.Point(138, 44);
            this.txtDesig.Name = "txtDesig";
            this.txtDesig.Size = new System.Drawing.Size(226, 20);
            this.txtDesig.TabIndex = 15;
            // 
            // lblDesig
            // 
            this.lblDesig.AutoSize = true;
            this.lblDesig.Location = new System.Drawing.Point(41, 44);
            this.lblDesig.Name = "lblDesig";
            this.lblDesig.Size = new System.Drawing.Size(89, 13);
            this.lblDesig.TabIndex = 17;
            this.lblDesig.Text = "Post Applying For";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 20);
            this.txtName.TabIndex = 13;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 356);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtExperience);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.txtQuali);
            this.Controls.Add(this.lblQuali);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtDesig);
            this.Controls.Add(this.lblDesig);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.Name = "frmEmployee";
            this.Text = "Employee Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.TextBox txtQuali;
        private System.Windows.Forms.Label lblQuali;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtDesig;
        private System.Windows.Forms.Label lblDesig;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label lblName;
    }
}

