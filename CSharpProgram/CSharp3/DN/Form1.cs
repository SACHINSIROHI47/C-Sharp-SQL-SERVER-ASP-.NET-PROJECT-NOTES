using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DN
{
    public partial class AssigningValues : Form
    {
        public AssigningValues()
        {
            InitializeComponent();
        }

        private void AssigningValues_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This is a assignmint
            String str = "Visual C#";
            int i = 2005;
            Boolean bol = true;
            MessageBox.Show(str + " " + i + " " + bol);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /*Use Mltple variables
            in C#
             Example*/
            String x;
            x = "Ram";
            String y;
            y = "Sharma";
            int z;
            z = 76;
            string str;
            str = " The age of := " + x + " " + y + " " + "is " + z;
            MessageBox.Show(str);

        }

        private void btnCheckingAge_Click(object sender, EventArgs e)
        {
            int result;
            Boolean status;
            result = Convert.ToInt32(txtAge.Text);
            status = result < 30;
            MessageBox.Show(status.ToString());
        }

       
        
    }
}
