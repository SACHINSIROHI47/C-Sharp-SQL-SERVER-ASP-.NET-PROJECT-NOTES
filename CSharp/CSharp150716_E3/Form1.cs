using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp150716_E3
{
    public partial class SubStringForm : Form
    {
        public SubStringForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String inputdata;
            inputdata = txtText.Text;

            String FromFirstChar;
            FromFirstChar = inputdata.Substring(0);

            MessageBox.Show(FromFirstChar, "From First Character");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String inputdata;
            inputdata = txtText.Text;

            int countLength;
            countLength = inputdata.Length;

            String FirstFourChars;
            if (countLength < 4)
            {
                MessageBox.Show("Plesase Enter atleast 4 characters");
            }
            else
            {
                FirstFourChars = inputdata.Substring(0, 4);

                MessageBox.Show(FirstFourChars, "First Four Characters");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            String inputdata;
            inputdata = txtText.Text;

            int countLength;
            countLength = inputdata.Length;

            String LastTwoChars;
            if (countLength > 2)
            {
                LastTwoChars = inputdata.Substring(countLength - 2);
                MessageBox.Show(LastTwoChars, "Last Two Character");
            }
            else
            {
                MessageBox.Show("Plesase Enter string of more than two characters");
            }
        }
    }
}
