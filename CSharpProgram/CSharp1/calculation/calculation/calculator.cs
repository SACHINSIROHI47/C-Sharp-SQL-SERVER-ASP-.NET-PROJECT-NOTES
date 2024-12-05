using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculation
{
    class calculator
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter Number 1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = num1 + num2;
            Console.WriteLine("Total is {0}", num3);
            Console.ReadLine();

        }
    }
}
