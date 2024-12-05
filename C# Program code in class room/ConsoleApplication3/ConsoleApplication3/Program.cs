using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        public int a, b, c;
        public int sum()
        {
            a = 10;
            b = 40;
            c=a+b;
            return c;
        }
        public int display()
        {
            Console.WriteLine(c);
            return 0;

        }

         static void Main(string[] args)
        {

            Program obj = new Program();
            obj.sum();
            obj.display();
            Console.ReadLine();

        }
    }
}
