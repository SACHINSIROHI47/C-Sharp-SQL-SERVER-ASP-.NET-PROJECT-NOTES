namespace Chapter4_E1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemDataEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFaculty = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStripItemStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripItemFaculty = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnStudent = new System.Windows.Forms.ToolStripButton();
            this.tsBtnFaculty = new System.Windows.Forms.ToolStripButton();
            this.tsBtnExit = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuStripItemStudent,
            this.contextMenuStripItemFaculty,
            this.contextMenuStripItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 70);
            // 
            // contextMenuStripItemStudent
            // 
            this.contextMenuStripItemStudent.Name = "contextMenuStripItemStudent";
            this.contextMenuStripItemStudent.Size = new System.Drawing.Size(123, 22);
            this.contextMenuStripItemStudent.Text = "Student";
            this.contextMenuStripItemStudent.Click += new System.EventHandler(this.contextMenuStripItemStudent_Click);
            // 
            // contextMenuStripItemFaculty
            // 
            this.contextMenuStripItemFaculty.Name = "contextMenuStripItemFaculty";
            this.contextMenuStripItemFaculty.Size = new System.Drawing.Size(123, 22);
            this.contextMenuStripItemFaculty.Text = "Faculty";
            this.contextMenuStripItemFaculty.Click += new System.EventHandler(this.contextMenuStripItemFaculty_Click);
            // 
            // contextMenuStripItemExit
            // 
            this.contextMenuStripItemExit.Name = "contextMenuStripItemExit";
            this.contextMenuStripItemExit.Size = new System.Drawing.Size(123, 22);
            this.contextMenuStripItemExit.Text = "Exit";
            this.contextMenuStripItemExit.Click += new System.EventHandler(this.contextMenuStripItemExit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnStudent,
            this.tsBtnFaculty,
            this.tsBtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(292, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnStudent
            // 
            this.tsBtnStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnStudent.Image")));
            this.tsBtnStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnStudent.Name = "tsBtnStudent";
            this.tsBtnStudent.Size = new System.Drawing.Size(23, 22);
            this.tsBtnStudent.Text = "Student";
            this.tsBtnStudent.ToolTipText = "Open Student Details Form";
            this.tsBtnStudent.Click += new System.EventHandler(this.tsBtnStudent_Click);
            // 
            // tsBtnFaculty
            // 
            this.tsBtnFaculty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFaculty.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFaculty.Image")));
            this.tsBtnFaculty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFaculty.Name = "tsBtnFaculty";
            this.tsBtnFaculty.Size = new System.Drawing.Size(23, 22);
            this.tsBtnFaculty.Text = "Faculty";
            this.tsBtnFaculty.ToolTipText = "Faculty Message box";
            this.tsBtnFaculty.Click += new System.EventHandler(this.tsBtnFaculty_Click);
            // 
            // tsBtnExit
            // 
            this.tsBtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExit.Image")));
            this.tsBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExit.Name = "tsBtnExit";
            this.tsBtnExit.Size = new System.Drawing.Size(23, 22);
            this.tsBtnExit.Text = "Exit";
            this.tsBtnExit.ToolTipText = "Terminate the Application";
            this.tsBtnExit.Click += new System.EventHandler(this.tsBtnExit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Student.ICO");
            this.imageList1.Images.SetKeyName(1, "Faculty.ICO");
            this.imageList1.Images.SetKeyName(2, "Exit.ICO");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Data Entry Form ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemDataEntry;
        private System.Windows.Forms.ToolStripMenuItem menuItemStudent;
        private System.Windows.Forms.ToolStripMenuItem menuItemFaculty;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStripItemStudent;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStripItemFaculty;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStripItemExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnStudent;
        private System.Windows.Forms.ToolStripButton tsBtnFaculty;
        private System.Windows.Forms.ToolStripButton tsBtnExit;
        private System.Windows.Forms.ImageList imageList1;
    }
}

