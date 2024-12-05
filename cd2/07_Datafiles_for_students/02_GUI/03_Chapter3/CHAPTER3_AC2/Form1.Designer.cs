namespace Chapter3_AC2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Child Node 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Child Node 2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Child Node 3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Parent Node", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lstDestination = new System.Windows.Forms.ListBox();
            this.treeViewSource = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(31, 57);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(100, 20);
            this.txtSource.TabIndex = 0;
            this.txtSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSource_MouseDown);
            // 
            // lstDestination
            // 
            this.lstDestination.AllowDrop = true;
            this.lstDestination.FormattingEnabled = true;
            this.lstDestination.Location = new System.Drawing.Point(182, 57);
            this.lstDestination.Name = "lstDestination";
            this.lstDestination.Size = new System.Drawing.Size(120, 121);
            this.lstDestination.TabIndex = 1;
            this.lstDestination.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstDestination_DragEnter);
            this.lstDestination.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDestination_DragDrop);
            // 
            // treeViewSource
            // 
            this.treeViewSource.Location = new System.Drawing.Point(31, 83);
            this.treeViewSource.Name = "treeViewSource";
            treeNode1.Name = "ChildNode1";
            treeNode1.Text = "Child Node 1";
            treeNode2.Name = "ChildNode2";
            treeNode2.Text = "Child Node 2";
            treeNode3.Name = "ChildNode3";
            treeNode3.Text = "Child Node 3";
            treeNode4.Name = "ParentNode";
            treeNode4.Text = "Parent Node";
            this.treeViewSource.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeViewSource.Size = new System.Drawing.Size(121, 97);
            this.treeViewSource.TabIndex = 2;
            this.treeViewSource.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewSource_ItemDrag);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Source Controls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination Control";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 346);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeViewSource);
            this.Controls.Add(this.lstDestination);
            this.Controls.Add(this.txtSource);
            this.Name = "Form1";
            this.Text = "Performing Drag and Drop Operations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.ListBox lstDestination;
        private System.Windows.Forms.TreeView treeViewSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

