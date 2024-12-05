namespace CSharp17062016
{
    partial class Form1
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
            this.lstState = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkLstFacility = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFacilities = new System.Windows.Forms.Button();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.btnCity = new System.Windows.Forms.Button();
            this.mcDateOfBirth = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDateOfBirth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstState
            // 
            this.lstState.FormattingEnabled = true;
            this.lstState.Items.AddRange(new object[] {
            "Andhra Pradesh",
            "Bihar",
            "Chhatisgrah",
            "Delhi",
            "Goa",
            "Madhya Pradesh",
            "Manipur",
            "Tamil Nadu",
            "Uttar Pradesh"});
            this.lstState.Location = new System.Drawing.Point(251, 36);
            this.lstState.Name = "lstState";
            this.lstState.Size = new System.Drawing.Size(120, 95);
            this.lstState.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select State";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(264, 150);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkLstFacility
            // 
            this.chkLstFacility.FormattingEnabled = true;
            this.chkLstFacility.Items.AddRange(new object[] {
            "Credit Card",
            "Debit Card",
            "Online Banking",
            "Over Draft Limt",
            "Cheque Book",
            "Digital Signature"});
            this.chkLstFacility.Location = new System.Drawing.Point(26, 62);
            this.chkLstFacility.Name = "chkLstFacility";
            this.chkLstFacility.Size = new System.Drawing.Size(140, 79);
            this.chkLstFacility.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Facility";
            // 
            // btnFacilities
            // 
            this.btnFacilities.Location = new System.Drawing.Point(55, 150);
            this.btnFacilities.Name = "btnFacilities";
            this.btnFacilities.Size = new System.Drawing.Size(75, 23);
            this.btnFacilities.TabIndex = 5;
            this.btnFacilities.Text = "Facilities";
            this.btnFacilities.UseVisualStyleBackColor = true;
            this.btnFacilities.Click += new System.EventHandler(this.btnFacilities_Click);
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.Location = new System.Drawing.Point(114, 208);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(200, 20);
            this.dtpTransactionDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-17, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Transaction Date";
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(114, 252);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 23);
            this.btnDate.TabIndex = 8;
            this.btnDate.Text = "Date";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select City";
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Ambala",
            "Bombay"});
            this.cmbCity.Location = new System.Drawing.Point(472, 27);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCity.TabIndex = 10;
            // 
            // btnCity
            // 
            this.btnCity.Location = new System.Drawing.Point(463, 76);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(75, 23);
            this.btnCity.TabIndex = 11;
            this.btnCity.Text = "City";
            this.btnCity.UseVisualStyleBackColor = true;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // mcDateOfBirth
            // 
            this.mcDateOfBirth.Location = new System.Drawing.Point(451, 176);
            this.mcDateOfBirth.Name = "mcDateOfBirth";
            this.mcDateOfBirth.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Select Date of Birth";
            // 
            // btnDateOfBirth
            // 
            this.btnDateOfBirth.Location = new System.Drawing.Point(364, 240);
            this.btnDateOfBirth.Name = "btnDateOfBirth";
            this.btnDateOfBirth.Size = new System.Drawing.Size(75, 23);
            this.btnDateOfBirth.TabIndex = 14;
            this.btnDateOfBirth.Text = "DateOfBirth";
            this.btnDateOfBirth.UseVisualStyleBackColor = true;
            this.btnDateOfBirth.Click += new System.EventHandler(this.btnDateOfBirth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 370);
            this.Controls.Add(this.btnDateOfBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mcDateOfBirth);
            this.Controls.Add(this.btnCity);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTransactionDate);
            this.Controls.Add(this.btnFacilities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkLstFacility);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstState);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckedListBox chkLstFacility;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFacilities;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Button btnCity;
        private System.Windows.Forms.MonthCalendar mcDateOfBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDateOfBirth;
    }
}

