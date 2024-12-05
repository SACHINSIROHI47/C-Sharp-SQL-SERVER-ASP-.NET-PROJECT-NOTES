namespace Multi_Threading
{
    partial class BackGroundWorker
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
            this.lblres = new System.Windows.Forms.Label();
            this.btnsync = new System.Windows.Forms.Button();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.lblgetinfo = new System.Windows.Forms.Button();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblprogress = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.lblnumber = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnasync = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(28, 214);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(37, 13);
            this.lblres.TabIndex = 25;
            this.lblres.Text = "Result";
            // 
            // btnsync
            // 
            this.btnsync.Location = new System.Drawing.Point(51, 128);
            this.btnsync.Name = "btnsync";
            this.btnsync.Size = new System.Drawing.Size(147, 23);
            this.btnsync.TabIndex = 24;
            this.btnsync.Text = "Calculate Sum Sync";
            this.btnsync.Click += new System.EventHandler(this.btnsync_Click);
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(295, 29);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(35, 13);
            this.lblPhoto.TabIndex = 23;
            this.lblPhoto.Text = "Photo";
            // 
            // lblgetinfo
            // 
            this.lblgetinfo.Location = new System.Drawing.Point(488, 345);
            this.lblgetinfo.Name = "lblgetinfo";
            this.lblgetinfo.Size = new System.Drawing.Size(75, 23);
            this.lblgetinfo.TabIndex = 21;
            this.lblgetinfo.Text = "Get Info";
            this.lblgetinfo.Click += new System.EventHandler(this.lblgetinfo_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(10, 345);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(230, 23);
            this.ProgressBar1.TabIndex = 20;
            this.ProgressBar1.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // lblprogress
            // 
            this.lblprogress.AutoSize = true;
            this.lblprogress.Location = new System.Drawing.Point(28, 310);
            this.lblprogress.Name = "lblprogress";
            this.lblprogress.Size = new System.Drawing.Size(48, 13);
            this.lblprogress.TabIndex = 19;
            this.lblprogress.Text = "Progress";
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresult.Location = new System.Drawing.Point(10, 244);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(230, 56);
            this.lblresult.TabIndex = 18;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(141, 26);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 15;
            this.txtnum.TextChanged += new System.EventHandler(this.txtnum_TextChanged);
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(32, 29);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(44, 13);
            this.lblnumber.TabIndex = 14;
            this.lblnumber.Text = "Number";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(83, 181);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 17;
            this.btncancel.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // BackgroundWorker1
            // 
            this.BackgroundWorker1.WorkerReportsProgress = true;
            this.BackgroundWorker1.WorkerSupportsCancellation = true;
            this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            this.BackgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            // 
            // btnasync
            // 
            this.btnasync.Location = new System.Drawing.Point(51, 80);
            this.btnasync.Name = "btnasync";
            this.btnasync.Size = new System.Drawing.Size(147, 23);
            this.btnasync.TabIndex = 16;
            this.btnasync.Text = "Calculate Sum  Async";
            this.btnasync.Click += new System.EventHandler(this.btnasync_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(353, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 271);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BackGroundWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 395);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.btnsync);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.lblgetinfo);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.lblprogress);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnasync);
            this.Name = "BackGroundWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackGroundWorker ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblres;
        internal System.Windows.Forms.Button btnsync;
        internal System.Windows.Forms.Label lblPhoto;
        internal System.Windows.Forms.Button lblgetinfo;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.Label lblprogress;
        internal System.Windows.Forms.Label lblresult;
        internal System.Windows.Forms.TextBox txtnum;
        internal System.Windows.Forms.Label lblnumber;
        internal System.Windows.Forms.Button btncancel;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal System.Windows.Forms.Button btnasync;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

