using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS270616_E4
{
    class MyClass
    {
        public int x;

        //Constructor is having same name as class
        //Called automattically as you create class object
        public MyClass(int i)
        {
            x = i;
        }
    }
    class ConsDemo
    {
        static void Main(string[] args)
        {
            MyClass t1 = new MyClass(10);
            MyClass t2 = new MyClass(68);

            Console.WriteLine(t1.x + " " + t2.x);

            Console.WriteLine("After Change");
            t1.x = 200;
            t2.x = 500;
            Console.WriteLine(t1.x + " " + t2.x);

            Console.ReadLine();
        }
    }
}