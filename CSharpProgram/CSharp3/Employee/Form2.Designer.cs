namespace Employee
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDayNo = new System.Windows.Forms.TextBox();
            this.btnDayName = new System.Windows.Forms.Button();
            this.lblDayName = new System.Windows.Forms.Label();
            this.btnDayName2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Day Number";
            // 
            // txtDayNo
            // 
            this.txtDayNo.Location = new System.Drawing.Point(146, 50);
            this.txtDayNo.Name = "txtDayNo";
            this.txtDayNo.Size = new System.Drawing.Size(100, 20);
            this.txtDayNo.TabIndex = 1;
            // 
            // btnDayName
            // 
            this.btnDayName.Location = new System.Drawing.Point(55, 103);
            this.btnDayName.Name = "btnDayName";
            this.btnDayName.Size = new System.Drawing.Size(75, 23);
            this.btnDayName.TabIndex = 2;
            this.btnDayName.Text = "Day Name";
            this.btnDayName.UseVisualStyleBackColor = true;
            this.btnDayName.Click += new System.EventHandler(this.btnDayName_Click);
            // 
            // lblDayName
            // 
            this.lblDayName.AutoSize = true;
            this.lblDayName.Location = new System.Drawing.Point(99, 9);
            this.lblDayName.Name = "lblDayName";
            this.lblDayName.Size = new System.Drawing.Size(57, 13);
            this.lblDayName.TabIndex = 3;
            this.lblDayName.Text = "Day Name";
            // 
            // btnDayName2
            // 
            this.btnDayName2.Location = new System.Drawing.Point(160, 103);
            this.btnDayName2.Name = "btnDayName2";
            this.btnDayName2.Size = new System.Drawing.Size(75, 23);
            this.btnDayName2.TabIndex = 4;
            this.btnDayName2.Text = "Day Name2";
            this.btnDayName2.UseVisualStyleBackColor = true;
            this.btnDayName2.Click += new System.EventHandler(this.btnDayName2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 148);
            this.Controls.Add(this.btnDayName2);
            this.Controls.Add(this.lblDayName);
            this.Controls.Add(this.btnDayName);
            this.Controls.Add(this.txtDayNo);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Calender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDayNo;
        private System.Windows.Forms.Button btnDayName;
        private System.Windows.Forms.Label lblDayName;
        private System.Windows.Forms.Button btnDayName2;
    }
}