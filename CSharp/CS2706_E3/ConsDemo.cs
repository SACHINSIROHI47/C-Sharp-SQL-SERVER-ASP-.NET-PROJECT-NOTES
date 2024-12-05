using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS2706_E3
{
    class MyClass
    {
        public int x;

        //Constructor is having same name as class
        //Called automattically as you create class object
        public MyClass()
        {
            x = 10;
        }
    }
    class ConsDemo
    {
        static void Main(string[] args)
        {
            MyClass t1 = new MyClass();
            MyClass t2 = new MyClass();

            Console.WriteLine(t1.x+ " " + t2.x);

            Console.WriteLine("After Change");            
            t1.x = 200;
            t2.x = 500;
            Console.WriteLine(t1.x + " " + t2.x);

            Console.ReadLine();
        }
    }
}
