using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp260716_E5
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] ga = new object[10];

            //Stores int
            for (int i = 0; i < 3; i++)
                ga[i] = i;

            //Stores double
            for (int i = 3; i < 6; i++)
                ga[i] = (double) i/2;

            //Store two strings., a bool, and a char
            ga[6] = "Hello";
            ga[7] = true;
            ga[8] = 'k';
            ga[9] = "End";

            //Stores double
            for (int i = 0; i < ga.Length; i++)
                Console.WriteLine("ga[" + i + "]" + " " + ga[i]);

            Console.ReadLine();
        }
    }
}
