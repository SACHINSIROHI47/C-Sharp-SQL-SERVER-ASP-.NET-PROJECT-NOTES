using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp210716_E1
{
    class A
    {
        public int i = 0;
    }

    //Create a derive class
    class B : A
    {
      new int i;  //this i hides i in A

        public B(int b)
        {
            i = b;
        }
        
        public void Show()
        {
            Console.WriteLine("i in derived class: " + i);
        }
    }
    
    class NameHiding
    {
        static void Main(string[] args)
        {
            B ob = new B(2);
            ob.Show();

            Console.ReadLine();
        }
    }
}
