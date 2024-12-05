using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp040716_E3
{
    class Program
    {
        static void Main(string[] args)
        {
             int sum = 0;
            int[] nums = new int[6];

            for (int i = 0; i < 6; i++)
                nums[i] = i;

            foreach (int x in nums)
            {
                Console.WriteLine("Value is: " + x);
                sum = sum + x;
                if (x == 4)
                    break;
            }
            Console.WriteLine("Summation: " + sum);
            Console.ReadLine();
        }
    }
}
