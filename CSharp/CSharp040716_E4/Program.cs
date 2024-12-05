using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp040716_E4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] nums = new int[2,3];

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    nums[i,j] = (i+j);

            foreach (int x in nums)
            {
                Console.WriteLine("Value is: " + x);
                sum += x;               
            }
            Console.WriteLine("Summation: " + sum);
            Console.ReadLine();
        }
    }
}
