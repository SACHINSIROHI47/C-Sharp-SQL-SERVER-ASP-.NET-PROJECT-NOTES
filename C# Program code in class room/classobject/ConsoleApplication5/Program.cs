using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        int a, b,c;

        public void disp()
        {
            Console.WriteLine("Display..");

        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            Program obj2 = new Program();
            Program obj3 = new Program();

            obj1.a = 60;
            obj2.b = obj1.a-10;
            obj3.c = obj1.a / obj2.b;
            Console.WriteLine("Object 1:-"+obj1.a);
            Console.WriteLine("Object 2:-"+obj2.b);
            Console.WriteLine("Object 3:-" + obj3.c);

            obj1.disp();
            obj2.disp();
            Console.ReadLine();


        }
    }
}
