using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp020716_E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4];

            Console.WriteLine("Length of the num is " + nums.Length);

            for (int i=0; i < nums.Length; i++)
                nums[i] = i * i;

            Console.Write("Here as nums: ");
            for (int i=0; i < nums.Length; i++)
                Console.Write(nums[i] + " ");

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
