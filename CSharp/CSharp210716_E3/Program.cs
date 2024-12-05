using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp210716_E3
{
    class A
    {
        public int i = 0;

        //Show in A class
        public void Show()
        {
            Console.WriteLine("i in base class: " + i);
        }
    }

    //Create a derive class
    class B : A
    {
        new int i;  //this i hides i in A

        public B(int a, int b)
        {
            base.i = a;
            i = b;
        }

        //this hides the show in A. Notice this use the new
        new public void Show()
        {
            base.Show();
            Console.WriteLine("i in derived class: " + i);
        }
    }
    class NameHiding
    {
        static void Main(string[] args)
        {
            B ob = new B(1, 2);
            ob.Show();

            Console.ReadLine();
        }
    }
}