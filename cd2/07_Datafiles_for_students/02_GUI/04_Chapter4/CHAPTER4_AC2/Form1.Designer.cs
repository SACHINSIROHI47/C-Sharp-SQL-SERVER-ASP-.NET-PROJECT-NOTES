namespace Chapter4_Ac2
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemDataEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFaculty = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDataEntry,
            this.menuItemExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemDataEntry
            // 
            this.menuItemDataEntry.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemStudent,
            this.menuItemFaculty});
            this.menuItemDataEntry.Name = "menuItemDataEntry";
            this.menuItemDataEntry.Size = new System.Drawing.Size(103, 20);
            this.menuItemDataEntry.Text = "&Data Entry Forms";
            // 
            // menuItemStudent
            // 
            this.menuItemStudent.Name = "menuItemStudent";
            this.menuItemStudent.Size = new System.Drawing.Size(158, 22);
            this.menuItemStudent.Text = "&Student Details";
            this.menuItemStudent.Click += new System.EventHandler(this.menuItemStudent_Click);
            // 
            // menuItemFaculty
            // 
            this.menuItemFaculty.Name = "menuItemFaculty";
            this.menuItemFaculty.Size = new System.Drawing.Size(158, 22);
            this.menuItemFaculty.Text = "&Faculty Details";
            this.menuItemFaculty.Click += new System.EventHandler(this.menuItemFaculty_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(37, 20);
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Data Entry Form ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemDataEntry;
        private System.Windows.Forms.ToolStripMenuItem menuItemStudent;
        private System.Windows.Forms.ToolStripMenuItem menuItemFaculty;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
    }
}

