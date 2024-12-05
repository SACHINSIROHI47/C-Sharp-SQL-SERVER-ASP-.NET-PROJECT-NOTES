namespace submission_form
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
            this.lblnumber1 = new System.Windows.Forms.Label();
            this.lblnumber2 = new System.Windows.Forms.Label();
            this.txtnumber1 = new System.Windows.Forms.TextBox();
            this.txtnumber2 = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btn1Sum = new System.Windows.Forms.Button();
            this.btn2Subtract = new System.Windows.Forms.Button();
            this.btn3Multiply = new System.Windows.Forms.Button();
            this.btn4Divide = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btn5Modulus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumber1
            // 
            this.lblnumber1.AutoSize = true;
            this.lblnumber1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblnumber1.Location = new System.Drawing.Point(35, 37);
            this.lblnumber1.Name = "lblnumber1";
            this.lblnumber1.Size = new System.Drawing.Size(64, 13);
            this.lblnumber1.TabIndex = 0;
            this.lblnumber1.Text = "First number";
            // 
            // lblnumber2
            // 
            this.lblnumber2.AutoSize = true;
            this.lblnumber2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblnumber2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnumber2.Location = new System.Drawing.Point(35, 96);
            this.lblnumber2.Name = "lblnumber2";
            this.lblnumber2.Size = new System.Drawing.Size(82, 13);
            this.lblnumber2.TabIndex = 1;
            this.lblnumber2.Text = "Second number";
            // 
            // txtnumber1
            // 
            this.txtnumber1.Location = new System.Drawing.Point(136, 34);
            this.txtnumber1.Name = "txtnumber1";
            this.txtnumber1.Size = new System.Drawing.Size(100, 20);
            this.txtnumber1.TabIndex = 3;
            // 
            // txtnumber2
            // 
            this.txtnumber2.Location = new System.Drawing.Point(136, 89);
            this.txtnumber2.Name = "txtnumber2";
            this.txtnumber2.Size = new System.Drawing.Size(100, 20);
            this.txtnumber2.TabIndex = 4;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(136, 156);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 0;
            // 
            // btn1Sum
            // 
            this.btn1Sum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn1Sum.Location = new System.Drawing.Point(38, 200);
            this.btn1Sum.Name = "btn1Sum";
            this.btn1Sum.Size = new System.Drawing.Size(75, 23);
            this.btn1Sum.TabIndex = 0;
            this.btn1Sum.Text = "Sum";
            this.btn1Sum.UseVisualStyleBackColor = false;
            this.btn1Sum.Click += new System.EventHandler(this.btn1Sum_Click);
            // 
            // btn2Subtract
            // 
            this.btn2Subtract.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn2Subtract.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn2Subtract.Location = new System.Drawing.Point(182, 203);
            this.btn2Subtract.Name = "btn2Subtract";
            this.btn2Subtract.Size = new System.Drawing.Size(75, 23);
            this.btn2Subtract.TabIndex = 5;
            this.btn2Subtract.Text = "Subtract";
            this.btn2Subtract.UseVisualStyleBackColor = false;
            this.btn2Subtract.Click += new System.EventHandler(this.btn2Subtract_Click);
            // 
            // btn3Multiply
            // 
            this.btn3Multiply.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn3Multiply.Location = new System.Drawing.Point(38, 258);
            this.btn3Multiply.Name = "btn3Multiply";
            this.btn3Multiply.Size = new System.Drawing.Size(75, 23);
            this.btn3Multiply.TabIndex = 6;
            this.btn3Multiply.Text = "Multiply";
            this.btn3Multiply.UseVisualStyleBackColor = false;
            this.btn3Multiply.Click += new System.EventHandler(this.btn3Multiply_Click);
            // 
            // btn4Divide
            // 
            this.btn4Divide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn4Divide.Location = new System.Drawing.Point(183, 256);
            this.btn4Divide.Name = "btn4Divide";
            this.btn4Divide.Size = new System.Drawing.Size(75, 23);
            this.btn4Divide.TabIndex = 7;
            this.btn4Divide.Text = "Divide";
            this.btn4Divide.UseVisualStyleBackColor = false;
            this.btn4Divide.Click += new System.EventHandler(this.btn4Divide_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotal.Location = new System.Drawing.Point(41, 156);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            // 
            // btn5Modulus
            // 
            this.btn5Modulus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn5Modulus.Location = new System.Drawing.Point(110, 229);
            this.btn5Modulus.Name = "btn5Modulus";
            this.btn5Modulus.Size = new System.Drawing.Size(75, 23);
            this.btn5Modulus.TabIndex = 9;
            this.btn5Modulus.Text = "Modulus";
            this.btn5Modulus.UseVisualStyleBackColor = false;
            this.btn5Modulus.Click += new System.EventHandler(this.btn5Modulus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(307, 298);
            this.Controls.Add(this.btn5Modulus);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btn4Divide);
            this.Controls.Add(this.btn3Multiply);
            this.Controls.Add(this.btn2Subtract);
            this.Controls.Add(this.btn1Sum);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtnumber2);
            this.Controls.Add(this.txtnumber1);
            this.Controls.Add(this.lblnumber2);
            this.Controls.Add(this.lblnumber1);
            this.Name = "Form1";
            this.Text = "CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumber1;
        private System.Windows.Forms.Label lblnumber2;
        private System.Windows.Forms.TextBox txtnumber1;
        private System.Windows.Forms.TextBox txtnumber2;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btn1Sum;
        private System.Windows.Forms.Button btn2Subtract;
        private System.Windows.Forms.Button btn3Multiply;
        private System.Windows.Forms.Button btn4Divide;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btn5Modulus;
    }
}

