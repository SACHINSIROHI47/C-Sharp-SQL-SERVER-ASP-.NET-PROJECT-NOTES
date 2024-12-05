namespace CSharp16062016
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.chkDebitCard = new System.Windows.Forms.CheckBox();
            this.chkCreditCard = new System.Windows.Forms.CheckBox();
            this.chkOnlineBanking = new System.Windows.Forms.CheckBox();
            this.btnFacilities = new System.Windows.Forms.Button();
            this.lblFacilities = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.btnCity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkDebitCard
            // 
            this.chkDebitCard.AutoSize = true;
            this.chkDebitCard.Location = new System.Drawing.Point(82, 82);
            this.chkDebitCard.Name = "chkDebitCard";
            this.chkDebitCard.Size = new System.Drawing.Size(76, 17);
            this.chkDebitCard.TabIndex = 1;
            this.chkDebitCard.Text = "Debit Card";
            this.chkDebitCard.UseVisualStyleBackColor = true;
            // 
            // chkCreditCard
            // 
            this.chkCreditCard.AutoSize = true;
            this.chkCreditCard.Location = new System.Drawing.Point(82, 106);
            this.chkCreditCard.Name = "chkCreditCard";
            this.chkCreditCard.Size = new System.Drawing.Size(78, 17);
            this.chkCreditCard.TabIndex = 2;
            this.chkCreditCard.Text = "Credit Card";
            this.chkCreditCard.UseVisualStyleBackColor = true;
            // 
            // chkOnlineBanking
            // 
            this.chkOnlineBanking.AutoSize = true;
            this.chkOnlineBanking.Location = new System.Drawing.Point(82, 129);
            this.chkOnlineBanking.Name = "chkOnlineBanking";
            this.chkOnlineBanking.Size = new System.Drawing.Size(98, 17);
            this.chkOnlineBanking.TabIndex = 3;
            this.chkOnlineBanking.Text = "Online Banking";
            this.chkOnlineBanking.UseVisualStyleBackColor = true;
            // 
            // btnFacilities
            // 
            this.btnFacilities.Location = new System.Drawing.Point(85, 164);
            this.btnFacilities.Name = "btnFacilities";
            this.btnFacilities.Size = new System.Drawing.Size(75, 23);
            this.btnFacilities.TabIndex = 4;
            this.btnFacilities.Text = "Facilities";
            this.btnFacilities.UseVisualStyleBackColor = true;
            this.btnFacilities.Click += new System.EventHandler(this.btnFacilities_Click);
            // 
            // lblFacilities
            // 
            this.lblFacilities.AutoSize = true;
            this.lblFacilities.Location = new System.Drawing.Point(82, 208);
            this.lblFacilities.Name = "lblFacilities";
            this.lblFacilities.Size = new System.Drawing.Size(47, 13);
            this.lblFacilities.TabIndex = 5;
            this.lblFacilities.Text = "Facilities";
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Allahbad",
            "Bareely",
            "Kanpur",
            "Meerut",
            "Nainital",
            "Shahranpur",
            "Panipat"});
            this.cmbCity.Location = new System.Drawing.Point(350, 57);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCity.TabIndex = 6;
            // 
            // btnCity
            // 
            this.btnCity.Location = new System.Drawing.Point(350, 106);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(75, 23);
            this.btnCity.TabIndex = 7;
            this.btnCity.Text = "City";
            this.btnCity.UseVisualStyleBackColor = true;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select City";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCity);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.lblFacilities);
            this.Controls.Add(this.btnFacilities);
            this.Controls.Add(this.chkOnlineBanking);
            this.Controls.Add(this.chkCreditCard);
            this.Controls.Add(this.chkDebitCard);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkDebitCard;
        private System.Windows.Forms.CheckBox chkCreditCard;
        private System.Windows.Forms.CheckBox chkOnlineBanking;
        private System.Windows.Forms.Button btnFacilities;
        private System.Windows.Forms.Label lblFacilities;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Button btnCity;
        private System.Windows.Forms.Label label1;
    }
}