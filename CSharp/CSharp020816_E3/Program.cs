using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp020816_E3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4];
            Console.WriteLine("Before exception is generated");
            for (int i = 0; i < 10; i++)
            {
                 nums[i] = i;
                 Console.WriteLine("nums[{0}] : {1}", i, nums[i]);
            }
            Console.WriteLine("this won't be displayed");
            Console.ReadLine();
        }
    }
}
