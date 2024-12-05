using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public string x, y, z;
        public int y1=10;
        public Form1()
        {
            InitializeComponent();
            
        }

       private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Page is Loaded.....");
            x = "10";
            y = "20";
            z = x + y;
        }

       private void button1_Click(object sender, EventArgs e)
       {
           String str, str2,str3;
           int a = 10, b = 20,c;
           str = "Visual c#";
           str2 = "Number a values:" + a + " Number b values: " + b;
           int i = 2005;
           Boolean bl = true;
           //MessageBox.Show(str+" "+i+" "+bl);
           MessageBox.Show(str2);
           MessageBox.Show(z);
           button1.Text = z;
           textBox1.Text = z;
         }

       private void button2_Click(object sender, EventArgs e)
       {
           String t1;
           int a1,a2=20,a3=35;
           t1 = textBox1.Text;
           a1 =Convert.ToInt32(t1);

           if ((a1 >10)&&(a1<100)&&(a2<30)||(a3==35))
           {
               MessageBox.Show("Less..");
           }
           else
           {
               MessageBox.Show("Not less");
           }
       }

       private void button3_Click(object sender, EventArgs e)
       {
           String sst;
           int days;
           sst = textBox1.Text;
           days = Convert.ToInt32(sst);
           if (days == 1)
           {
               MessageBox.Show("Sunday");
           }
           else if(days==2)
           {
               MessageBox.Show("Monday");
           }
           else if (days == 3)
           {
               MessageBox.Show("Tuesday");
           }
           else if (days == 4)
           {
               MessageBox.Show("wednesday");
           }
           else if (days == 5)
           {
               MessageBox.Show("thursday");
           }
           else if (days == 6)
           {
               MessageBox.Show("Friday");
           }
           else if (days == 7)
           {
               MessageBox.Show("saturday");
           }
           else
           {
               MessageBox.Show("No days is found");
           }
       }

       private void button4_Click(object sender, EventArgs e)
       {

           String days;
           //char ch;
           //ch=Convert.ToChar(textBox1.Text);
           days = textBox1.Text;
           if (days == "sun")
           {
               MessageBox.Show("Sunday");
           }
           else if(days=="mon")
           {
               MessageBox.Show("Monday");
           }
           else if (days == "tue")
           {
               MessageBox.Show("Tuesday");
           }
           else if (days == "wed")
           {
               MessageBox.Show("wednesday");
           }
           else if (days == "thu")
           {
               MessageBox.Show("thursday");
           }
           else if (days == "fri")
           {
               MessageBox.Show("Friday");
           }
           else if (days == "sat")
           {
               MessageBox.Show("saturday");
           }
           //else if(ch=='s')
           //{
             //  MessageBox.Show("saturday 2222");
           //}
           else
           {
               MessageBox.Show("No days is found");
           }
       
       }

       private void button5_Click(object sender, EventArgs e)
       {
           int i;
           for (i = 0; i < 10; i++)
           {
               MessageBox.Show("Hello"+i);
           }
       }

       private void button6_Click(object sender, EventArgs e)
       {
           try
           {
               int x1 = 5, x2, x3;
               x2 = Convert.ToInt32(textBox1.Text);
               x3 = x1 / x2;
               String s1 = Convert.ToString(x3);
               MessageBox.Show(s1);
           }
           catch (Exception e1)
           {

               //MessageBox.Show("Exception:"+e1);
               MessageBox.Show("Divide by zero Exception..");
           }
           finally
           {
               MessageBox.Show("finally keyword is execute");
           }
       }

       private int button7_Click(object sender, EventArgs e)
       {
           y1 = 20; 
           return y1;

       }

       private int button8_Click(object sender, EventArgs e)
       {
           String xxy;
           xxy = Convert.ToString(y1);
           MessageBox.Show(xxy);
           return 0;

       }

      
  

      
    }
}
