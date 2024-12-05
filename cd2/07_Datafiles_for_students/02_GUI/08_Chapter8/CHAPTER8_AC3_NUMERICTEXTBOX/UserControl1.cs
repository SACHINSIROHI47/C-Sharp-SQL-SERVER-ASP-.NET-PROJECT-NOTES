using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Chapter8_Ac3_NumericTextBox
{
    public partial class UserControl1 : System.Windows.Forms.TextBox
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false)
                e.Handled = true;
        }

    }
}