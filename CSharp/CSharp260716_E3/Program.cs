using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp260716_E3
{
    class BoxingDemo
    {
        static void Main(string[] args)
        {
            int x;

            x = 10;
            Console.WriteLine("How is x " + x);
            
            //x is automattically boxed when passed to Sqr()
            x = BoxingDemo.Sqr(x);

            Console.WriteLine("Here is a x squared: " + x);

            Console.ReadLine();

        }

        static int Sqr(object o)
        {
            return (int)o * (int)o;
        }
    }
}
