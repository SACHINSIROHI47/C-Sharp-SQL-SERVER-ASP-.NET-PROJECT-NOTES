using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculation
{
    class MyCalculation
    {
        public int difference(int var1, int var2)
        {
            int var3;
            var3 = var1 - var2;
            return var3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyCalculation object1 = new MyCalculation();

            int result;

            result = object1.difference(9, 3);

            Console.WriteLine("Difference is {0}",result);

            Console.WriteLine("Difference is {0}", object1.difference(45, 100));

            Console.ReadLine();

        }
    }
}
