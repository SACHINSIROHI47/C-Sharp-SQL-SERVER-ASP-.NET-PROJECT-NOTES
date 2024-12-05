namespace Employee
{
    partial class Form5
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
            this.btnIntegerArray = new System.Windows.Forms.Button();
            this.btnStringArray = new System.Windows.Forms.Button();
            this.btnFloatArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIntegerArray
            // 
            this.btnIntegerArray.Location = new System.Drawing.Point(90, 41);
            this.btnIntegerArray.Name = "btnIntegerArray";
            this.btnIntegerArray.Size = new System.Drawing.Size(75, 23);
            this.btnIntegerArray.TabIndex = 0;
            this.btnIntegerArray.Text = "Integer Array";
            this.btnIntegerArray.UseVisualStyleBackColor = true;
            this.btnIntegerArray.Click += new System.EventHandler(this.btnIntegerArray_Click);
            // 
            // btnStringArray
            // 
            this.btnStringArray.Location = new System.Drawing.Point(90, 91);
            this.btnStringArray.Name = "btnStringArray";
            this.btnStringArray.Size = new System.Drawing.Size(75, 23);
            this.btnStringArray.TabIndex = 1;
            this.btnStringArray.Text = "String Array";
            this.btnStringArray.UseVisualStyleBackColor = true;
            this.btnStringArray.Click += new System.EventHandler(this.btnStringArray_Click);
            // 
            // btnFloatArray
            // 
            this.btnFloatArray.Location = new System.Drawing.Point(90, 142);
            this.btnFloatArray.Name = "btnFloatArray";
            this.btnFloatArray.Size = new System.Drawing.Size(75, 23);
            this.btnFloatArray.TabIndex = 2;
            this.btnFloatArray.Text = "Float Array";
            this.btnFloatArray.UseVisualStyleBackColor = true;
            this.btnFloatArray.Click += new System.EventHandler(this.btnFloatArray_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnFloatArray);
            this.Controls.Add(this.btnStringArray);
            this.Controls.Add(this.btnIntegerArray);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIntegerArray;
        private System.Windows.Forms.Button btnStringArray;
        private System.Windows.Forms.Button btnFloatArray;
    }
}