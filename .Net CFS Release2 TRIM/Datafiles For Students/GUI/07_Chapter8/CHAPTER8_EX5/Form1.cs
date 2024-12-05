using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chapter8_Ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student stdObj = new Student();
            stdObj.StudentAge = 20;
            MessageBox.Show(stdObj.StudentAge.ToString());
        }
    }

    class Student
    {
	    private int age;
    	public int StudentAge
        {
            get
	        {
                return(age);
            }
    
            set
	        {
                if ((value > 12) && (value < 27))
                    age = value;
                else
 		            MessageBox.Show("Age should be between 12 years and 27 years");
            }
        }
}

}