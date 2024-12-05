using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp290616_E3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 99, 10, 100, 18 };

            float total = 0;
            float avg = 0;

            for (int i = 0; i < 100; i = i + 1)
                total = total + nums[i];

            Console.WriteLine("Total : " + total);

            avg = total / 4;

            Console.WriteLine("Average : " + avg);

            Console.ReadLine();
        }
    }
}
