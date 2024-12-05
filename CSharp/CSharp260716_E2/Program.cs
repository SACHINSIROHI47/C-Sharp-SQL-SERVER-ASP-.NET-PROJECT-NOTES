using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp260716_E2
{
    class BoxingDemo
    {
        static void Main(string[] args)
        {
            int x;            
            x = 10;

            object obj;

            Console.WriteLine("value of x = " + x);

            //Boxing
            obj = x;

            Console.WriteLine("value of obj = " + obj);

            int y;

            //Unboxing with type casting
            y = (int)obj;

            Console.WriteLine("value of y = " + y);

            Console.ReadLine();
        }
    }
}
