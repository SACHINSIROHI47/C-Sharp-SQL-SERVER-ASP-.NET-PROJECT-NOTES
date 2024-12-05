namespace BackGroundWorkerDemo
{
    partial class frmBGDemo
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
            this.lblEnterNo = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.txtPrime = new System.Windows.Forms.TextBox();
            this.lblPrime = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.BtnAsync = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblEnterNo
            // 
            this.lblEnterNo.AutoSize = true;
            this.lblEnterNo.Location = new System.Drawing.Point(31, 24);
            this.lblEnterNo.Name = "lblEnterNo";
            this.lblEnterNo.Size = new System.Drawing.Size(79, 13);
            this.lblEnterNo.TabIndex = 0;
            this.lblEnterNo.Text = "Enter a number";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(132, 21);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(185, 20);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(132, 70);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(88, 23);
            this.btnSync.TabIndex = 2;
            this.btnSync.Text = "&Calculate Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // txtPrime
            // 
            this.txtPrime.Location = new System.Drawing.Point(132, 122);
            this.txtPrime.Name = "txtPrime";
            this.txtPrime.Size = new System.Drawing.Size(185, 20);
            this.txtPrime.TabIndex = 4;
            // 
            // lblPrime
            // 
            this.lblPrime.AutoSize = true;
            this.lblPrime.Location = new System.Drawing.Point(31, 122);
            this.lblPrime.Name = "lblPrime";
            this.lblPrime.Size = new System.Drawing.Size(85, 13);
            this.lblPrime.TabIndex = 3;
            this.lblPrime.Text = "Total Prime Nos.";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(166, 166);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BtnAsync
            // 
            this.BtnAsync.Location = new System.Drawing.Point(226, 70);
            this.BtnAsync.Name = "BtnAsync";
            this.BtnAsync.Size = new System.Drawing.Size(91, 23);
            this.BtnAsync.TabIndex = 7;
            this.BtnAsync.Text = "&Calculate Async";
            this.BtnAsync.UseVisualStyleBackColor = true;
            this.BtnAsync.Click += new System.EventHandler(this.BtnAsync_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted_1);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // frmBGDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 229);
            this.Controls.Add(this.BtnAsync);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPrime);
            this.Controls.Add(this.lblPrime);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblEnterNo);
            this.MaximizeBox = false;
            this.Name = "frmBGDemo";
            this.Text = "BackGroundWorker Demo";
            this.Load += new System.EventHandler(this.frmBGDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNo;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.TextBox txtPrime;
        private System.Windows.Forms.Label lblPrime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button BtnAsync;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

