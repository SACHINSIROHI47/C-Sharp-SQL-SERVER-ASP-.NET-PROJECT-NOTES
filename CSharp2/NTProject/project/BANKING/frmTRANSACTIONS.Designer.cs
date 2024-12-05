namespace BANKING
{
    partial class frmTRANSACTIONS
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
            this.cmbTranactionNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtTranactionDate = new System.Windows.Forms.TextBox();
            this.dtTranactionDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTranactionType = new System.Windows.Forms.ComboBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdNew = new System.Windows.Forms.Button();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDocumentType = new System.Windows.Forms.ComboBox();
            this.txtDocumentNumber = new System.Windows.Forms.TextBox();
            this.txtCreditLimit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAccountType = new System.Windows.Forms.TextBox();
            this.dgvAccountDetails = new System.Windows.Forms.DataGridView();
            this.cmdTransactionsDetails = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbACNO = new System.Windows.Forms.ComboBox();
            this.cmdacTransactionsDetails = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTranactionNo
            // 
            this.cmbTranactionNo.FormattingEnabled = true;
            this.cmbTranactionNo.Location = new System.Drawing.Point(148, 20);
            this.cmbTranactionNo.Name = "cmbTranactionNo";
            this.cmbTranactionNo.Size = new System.Drawing.Size(200, 21);
            this.cmbTranactionNo.TabIndex = 0;
            this.cmbTranactionNo.SelectedIndexChanged += new System.EventHandler(this.cmbTranactionNo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tranaction Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tranaction Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(148, 141);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(200, 20);
            this.txtBalance.TabIndex = 8;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(148, 261);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 20);
            this.txtAmount.TabIndex = 9;
            // 
            // txtTranactionDate
            // 
            this.txtTranactionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTranactionDate.Location = new System.Drawing.Point(148, 291);
            this.txtTranactionDate.Name = "txtTranactionDate";
            this.txtTranactionDate.Size = new System.Drawing.Size(200, 21);
            this.txtTranactionDate.TabIndex = 10;
            // 
            // dtTranactionDate
            // 
            this.dtTranactionDate.Location = new System.Drawing.Point(148, 321);
            this.dtTranactionDate.Name = "dtTranactionDate";
            this.dtTranactionDate.Size = new System.Drawing.Size(200, 20);
            this.dtTranactionDate.TabIndex = 14;
            this.dtTranactionDate.ValueChanged += new System.EventHandler(this.dtTranactionDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tranaction Type";
            // 
            // cmbTranactionType
            // 
            this.cmbTranactionType.FormattingEnabled = true;
            this.cmbTranactionType.Location = new System.Drawing.Point(148, 171);
            this.cmbTranactionType.Name = "cmbTranactionType";
            this.cmbTranactionType.Size = new System.Drawing.Size(200, 21);
            this.cmbTranactionType.TabIndex = 20;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(513, 82);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 21;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdNew
            // 
            this.cmdNew.Location = new System.Drawing.Point(513, 24);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(75, 23);
            this.cmdNew.TabIndex = 22;
            this.cmdNew.Text = "New";
            this.cmdNew.UseVisualStyleBackColor = true;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(513, 112);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 24;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(513, 53);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 27;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Document Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Document Number";
            // 
            // cmbDocumentType
            // 
            this.cmbDocumentType.FormattingEnabled = true;
            this.cmbDocumentType.Location = new System.Drawing.Point(148, 201);
            this.cmbDocumentType.Name = "cmbDocumentType";
            this.cmbDocumentType.Size = new System.Drawing.Size(200, 21);
            this.cmbDocumentType.TabIndex = 30;
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Location = new System.Drawing.Point(148, 231);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(200, 20);
            this.txtDocumentNumber.TabIndex = 31;
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditLimit.Location = new System.Drawing.Point(148, 111);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Size = new System.Drawing.Size(200, 20);
            this.txtCreditLimit.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Credit Limit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Account Type";
            // 
            // txtAccountType
            // 
            this.txtAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountType.Location = new System.Drawing.Point(148, 81);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Size = new System.Drawing.Size(200, 20);
            this.txtAccountType.TabIndex = 36;
            // 
            // dgvAccountDetails
            // 
            this.dgvAccountDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountDetails.Location = new System.Drawing.Point(28, 364);
            this.dgvAccountDetails.Name = "dgvAccountDetails";
            this.dgvAccountDetails.Size = new System.Drawing.Size(764, 137);
            this.dgvAccountDetails.TabIndex = 37;
            // 
            // cmdTransactionsDetails
            // 
            this.cmdTransactionsDetails.Location = new System.Drawing.Point(396, 286);
            this.cmdTransactionsDetails.Name = "cmdTransactionsDetails";
            this.cmdTransactionsDetails.Size = new System.Drawing.Size(119, 24);
            this.cmdTransactionsDetails.TabIndex = 38;
            this.cmdTransactionsDetails.Text = "All Transactions Details";
            this.cmdTransactionsDetails.UseVisualStyleBackColor = true;
            this.cmdTransactionsDetails.Click += new System.EventHandler(this.cmdTransactionsDetails_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Number";
            // 
            // cmbACNO
            // 
            this.cmbACNO.FormattingEnabled = true;
            this.cmbACNO.Location = new System.Drawing.Point(148, 51);
            this.cmbACNO.Name = "cmbACNO";
            this.cmbACNO.Size = new System.Drawing.Size(200, 21);
            this.cmbACNO.TabIndex = 13;
            this.cmbACNO.SelectedIndexChanged += new System.EventHandler(this.cmbACNO_SelectedIndexChanged);
            // 
            // cmdacTransactionsDetails
            // 
            this.cmdacTransactionsDetails.Location = new System.Drawing.Point(376, 320);
            this.cmdacTransactionsDetails.Name = "cmdacTransactionsDetails";
            this.cmdacTransactionsDetails.Size = new System.Drawing.Size(177, 25);
            this.cmdacTransactionsDetails.TabIndex = 39;
            this.cmdacTransactionsDetails.Text = "Account Wise Transactions Details";
            this.cmdacTransactionsDetails.UseVisualStyleBackColor = true;
            this.cmdacTransactionsDetails.Click += new System.EventHandler(this.cmdacTransactionsDetails_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BANKING.Properties.Resources.images83;
            this.pictureBox2.Location = new System.Drawing.Point(596, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 333);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(365, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 167);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // frmTRANSACTIONS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(804, 524);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdacTransactionsDetails);
            this.Controls.Add(this.cmdTransactionsDetails);
            this.Controls.Add(this.dgvAccountDetails);
            this.Controls.Add(this.txtAccountType);
            this.Controls.Add(this.txtCreditLimit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDocumentNumber);
            this.Controls.Add(this.cmbDocumentType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmbTranactionType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtTranactionDate);
            this.Controls.Add(this.cmbACNO);
            this.Controls.Add(this.txtTranactionDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTranactionNo);
            this.Name = "frmTRANSACTIONS";
            this.Text = "Tranaction Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTRANSACTIONS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTranactionNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtTranactionDate;
        private System.Windows.Forms.DateTimePicker dtTranactionDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTranactionType;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdNew;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDocumentType;
        private System.Windows.Forms.TextBox txtDocumentNumber;
        private System.Windows.Forms.TextBox txtCreditLimit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAccountType;
        private System.Windows.Forms.DataGridView dgvAccountDetails;
        private System.Windows.Forms.Button cmdTransactionsDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdacTransactionsDetails;
        protected internal System.Windows.Forms.ComboBox cmbACNO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}