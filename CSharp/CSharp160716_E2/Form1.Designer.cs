namespace CSharp160716_E2
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
            this.chkSports = new System.Windows.Forms.CheckBox();
            this.chkPainting = new System.Windows.Forms.CheckBox();
            this.chkReading = new System.Windows.Forms.CheckBox();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.chkSinging = new System.Windows.Forms.CheckBox();
            this.chkChatting = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUserChoice = new System.Windows.Forms.Button();
            this.btnCancelUserChoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkSports
            // 
            this.chkSports.AutoSize = true;
            this.chkSports.Location = new System.Drawing.Point(76, 34);
            this.chkSports.Name = "chkSports";
            this.chkSports.Size = new System.Drawing.Size(56, 17);
            this.chkSports.TabIndex = 0;
            this.chkSports.Text = "Sports";
            this.chkSports.UseVisualStyleBackColor = true;
            // 
            // chkPainting
            // 
            this.chkPainting.AutoSize = true;
            this.chkPainting.Location = new System.Drawing.Point(76, 84);
            this.chkPainting.Name = "chkPainting";
            this.chkPainting.Size = new System.Drawing.Size(64, 17);
            this.chkPainting.TabIndex = 1;
            this.chkPainting.Text = "Painting";
            this.chkPainting.UseVisualStyleBackColor = true;
            // 
            // chkReading
            // 
            this.chkReading.AutoSize = true;
            this.chkReading.Location = new System.Drawing.Point(76, 138);
            this.chkReading.Name = "chkReading";
            this.chkReading.Size = new System.Drawing.Size(66, 17);
            this.chkReading.TabIndex = 2;
            this.chkReading.Text = "Reading";
            this.chkReading.UseVisualStyleBackColor = true;
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Location = new System.Drawing.Point(190, 34);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(54, 17);
            this.chkMusic.TabIndex = 3;
            this.chkMusic.Text = "Music";
            this.chkMusic.UseVisualStyleBackColor = true;
            // 
            // chkSinging
            // 
            this.chkSinging.AutoSize = true;
            this.chkSinging.Location = new System.Drawing.Point(190, 84);
            this.chkSinging.Name = "chkSinging";
            this.chkSinging.Size = new System.Drawing.Size(61, 17);
            this.chkSinging.TabIndex = 4;
            this.chkSinging.Text = "Singing";
            this.chkSinging.UseVisualStyleBackColor = true;
            // 
            // chkChatting
            // 
            this.chkChatting.AutoSize = true;
            this.chkChatting.Location = new System.Drawing.Point(190, 138);
            this.chkChatting.Name = "chkChatting";
            this.chkChatting.Size = new System.Drawing.Size(65, 17);
            this.chkChatting.TabIndex = 5;
            this.chkChatting.Text = "Chatting";
            this.chkChatting.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Check State (Music)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Set Checked (Painting)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUserChoice
            // 
            this.btnUserChoice.Location = new System.Drawing.Point(47, 235);
            this.btnUserChoice.Name = "btnUserChoice";
            this.btnUserChoice.Size = new System.Drawing.Size(75, 23);
            this.btnUserChoice.TabIndex = 8;
            this.btnUserChoice.Text = "User Choice";
            this.btnUserChoice.UseVisualStyleBackColor = true;
            this.btnUserChoice.Click += new System.EventHandler(this.btnUserChoice_Click);
            // 
            // btnCancelUserChoice
            // 
            this.btnCancelUserChoice.Location = new System.Drawing.Point(173, 235);
            this.btnCancelUserChoice.Name = "btnCancelUserChoice";
            this.btnCancelUserChoice.Size = new System.Drawing.Size(111, 23);
            this.btnCancelUserChoice.TabIndex = 9;
            this.btnCancelUserChoice.Text = "Cancel User Choice";
            this.btnCancelUserChoice.UseVisualStyleBackColor = true;
            this.btnCancelUserChoice.Click += new System.EventHandler(this.btnCancelUserChoice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 284);
            this.Controls.Add(this.btnCancelUserChoice);
            this.Controls.Add(this.btnUserChoice);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkChatting);
            this.Controls.Add(this.chkSinging);
            this.Controls.Add(this.chkMusic);
            this.Controls.Add(this.chkReading);
            this.Controls.Add(this.chkPainting);
            this.Controls.Add(this.chkSports);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSports;
        private System.Windows.Forms.CheckBox chkPainting;
        private System.Windows.Forms.CheckBox chkReading;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.CheckBox chkSinging;
        private System.Windows.Forms.CheckBox chkChatting;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUserChoice;
        private System.Windows.Forms.Button btnCancelUserChoice;
    }
}

