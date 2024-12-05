namespace Chapter3_AC3
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("VC#");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("VB.NET");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Languages", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("SQL Server 2005");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Oracle");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Databases", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.lbDestinationItem = new System.Windows.Forms.ListBox();
            this.treeViewItems = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDestinationItem
            // 
            this.lbDestinationItem.FormattingEnabled = true;
            this.lbDestinationItem.Location = new System.Drawing.Point(12, 63);
            this.lbDestinationItem.Name = "lbDestinationItem";
            this.lbDestinationItem.Size = new System.Drawing.Size(120, 134);
            this.lbDestinationItem.TabIndex = 0;
            // 
            // treeViewItems
            // 
            this.treeViewItems.Location = new System.Drawing.Point(149, 63);
            this.treeViewItems.Name = "treeViewItems";
            treeNode1.Name = "vcSharpNode";
            treeNode1.Text = "VC#";
            treeNode2.Name = "vbNode";
            treeNode2.Text = "VB.NET";
            treeNode3.Name = "langNode";
            treeNode3.Text = "Languages";
            treeNode4.Name = "sqlNode";
            treeNode4.Text = "SQL Server 2005";
            treeNode5.Name = "oracleNode";
            treeNode5.Text = "Oracle";
            treeNode6.Name = "databaseNode";
            treeNode6.Text = "Databases";
            this.treeViewItems.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeViewItems.Size = new System.Drawing.Size(147, 131);
            this.treeViewItems.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Destination List Box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Source ";
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(15, 200);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 6;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(149, 200);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 266);
            this.Controls.Add(this.treeViewItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDestinationItem);
            this.Name = "Form1";
            this.Text = "Working With Clipboard ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDestinationItem;
        private System.Windows.Forms.TreeView treeViewItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
    }
}

