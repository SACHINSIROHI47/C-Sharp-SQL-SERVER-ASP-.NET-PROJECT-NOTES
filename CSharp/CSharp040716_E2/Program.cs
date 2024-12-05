using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp040716_E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] nums = new int[4];

            for (int i = 0; i < 4; i++)
                nums[i] = i;

            foreach (int x in nums)
            {
                Console.WriteLine("Value is: " + x);
                sum = sum + x;                
            }
            Console.WriteLine("Summation: " + sum);
            Console.ReadLine();
        }
    }
}
