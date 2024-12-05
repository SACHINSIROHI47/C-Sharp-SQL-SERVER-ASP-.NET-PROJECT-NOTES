namespace Lesson_Ex1
{
    partial class frmPAN
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
            this.components = new System.ComponentModel.Container();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpCode = new System.Windows.Forms.TextBox();
            this.lblEmpCode = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDOJ = new System.Windows.Forms.Label();
            this.dtDOJ = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(31, 21);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(84, 13);
            this.lblEmpName.TabIndex = 0;
            this.lblEmpName.Text = "Employee Name";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(137, 18);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(241, 20);
            this.txtEmpName.TabIndex = 1;
            this.txtEmpName.Enter += new System.EventHandler(this.txtEmpName_Enter);
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.Location = new System.Drawing.Point(137, 44);
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.Size = new System.Drawing.Size(241, 20);
            this.txtEmpCode.TabIndex = 3;
            this.txtEmpCode.Enter += new System.EventHandler(this.txtEmpCode_Enter);
            this.txtEmpCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpCode_KeyPress);
            // 
            // lblEmpCode
            // 
            this.lblEmpCode.AutoSize = true;
            this.lblEmpCode.Location = new System.Drawing.Point(31, 47);
            this.lblEmpCode.Name = "lblEmpCode";
            this.lblEmpCode.Size = new System.Drawing.Size(81, 13);
            this.lblEmpCode.TabIndex = 2;
            this.lblEmpCode.Text = "Employee Code";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(137, 70);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(241, 64);
            this.txtAdd.TabIndex = 5;
            this.txtAdd.Enter += new System.EventHandler(this.txtAdd_Enter);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(31, 73);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(99, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Permanent Address";
            // 
            // lblDOJ
            // 
            this.lblDOJ.AutoSize = true;
            this.lblDOJ.Location = new System.Drawing.Point(31, 144);
            this.lblDOJ.Name = "lblDOJ";
            this.lblDOJ.Size = new System.Drawing.Size(78, 13);
            this.lblDOJ.TabIndex = 6;
            this.lblDOJ.Text = "Date of Joining";
            // 
            // dtDOJ
            // 
            this.dtDOJ.Location = new System.Drawing.Point(137, 144);
            this.dtDOJ.Name = "dtDOJ";
            this.dtDOJ.Size = new System.Drawing.Size(241, 20);
            this.dtDOJ.TabIndex = 7;
            this.dtDOJ.Enter += new System.EventHandler(this.dtDOJ_Enter);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(137, 211);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(179, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 254);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(433, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssLabel
            // 
            this.tssLabel.Name = "tssLabel";
            this.tssLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 276);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dtDOJ);
            this.Controls.Add(this.lblDOJ);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtEmpCode);
            this.Controls.Add(this.lblEmpCode);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblEmpName);
            this.MaximizeBox = false;
            this.Name = "frmPAN";
            this.Text = "PAN Registration Form";
            this.Load += new System.EventHandler(this.frmPAN_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpCode;
        private System.Windows.Forms.Label lblEmpCode;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDOJ;
        private System.Windows.Forms.DateTimePicker dtDOJ;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

