using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp16062016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display();
        }
                private void button2_Click(object sender, EventArgs e)
        {
            Display();
        }
        public void Display()
        {
             MessageBox.Show("Welcome To RGPG");
             MessageBox.Show("Life Begins at RGPG");
             MessageBox.Show("Never Say Bye");
        }
        public String ShowMessage()
        {
            return "Be More Ambitious";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String str;
            str = ShowMessage();
            MessageBox.Show(str);
        }
        
       

    }
}
