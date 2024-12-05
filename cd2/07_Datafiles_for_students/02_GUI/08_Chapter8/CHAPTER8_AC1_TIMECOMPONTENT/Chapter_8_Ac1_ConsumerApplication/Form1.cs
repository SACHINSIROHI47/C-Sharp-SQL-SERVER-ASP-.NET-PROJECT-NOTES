using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chapter_8_Ac1_ConsumerApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chapter8_Ac1_TimeCompontent.TimeProvide myobj = new Chapter8_Ac1_TimeCompontent.TimeProvide();
            label1.Text = myobj.Time;
            
        }
    }
}