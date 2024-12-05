using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chapter8_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Chapter8_Ex2.StudentMarks s=new Chapter8_Ex2.StudentMarks();
            s.ShowScore();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentMarks s1=new StudentMarks(4);
            s1.ShowScore();
        }
    }

    public class StudentMarks
    {
    int marksScored; //Constructor to initialize marksScored
    public StudentMarks()
    {
      marksScored = 0;
    }

    public StudentMarks(int marks) //Overloaded constructor
    {
      marksScored = marks;
    }
    
    public void ShowScore()
    {
      MessageBox.Show("Marks scored: " + marksScored);
    }
    }   

}