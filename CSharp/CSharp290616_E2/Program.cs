using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp290616_E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4];
            float total = 0;
            float avg = 0;

            nums[0]=99;
            nums[1]=10;
            nums[2]=100;
            nums[3]=18;

            for (int i = 0; i < 4; i = i + 1)
                total = total + nums[i];

            Console.WriteLine("Total : " + total);

            avg = total / 4;

            Console.WriteLine("Average : " + avg);

            Console.ReadLine();
        }
    }
}
