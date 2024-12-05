using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chapter3_AC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSource_MouseDown(object sender, MouseEventArgs e)
        {
            txtSource.DoDragDrop(txtSource.Text, DragDropEffects.Move);

        }

        private void lstDestination_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Move;
        }

        private void lstDestination_DragDrop(object sender, DragEventArgs e)
        {
            lstDestination.Items.Add(e.Data.GetData(DataFormats.Text).ToString());
            e.Effect = DragDropEffects.Move;
        }

       

        private void treeViewSource_ItemDrag(object sender, ItemDragEventArgs e)
        {
            TreeNode SelectedItem = (TreeNode)e.Item;
            treeViewSource.DoDragDrop(SelectedItem.Text, DragDropEffects.Move|DragDropEffects.Copy );
        }

       

        

       

        
    }
}