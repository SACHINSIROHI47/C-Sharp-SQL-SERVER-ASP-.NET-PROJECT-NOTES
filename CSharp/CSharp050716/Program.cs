using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp050716
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4];
            int val;
            bool found = false;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter Number{0} : ",i+1);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter Number to be Searched : ");
            val = Convert.ToInt32(Console.ReadLine());
            //val = 2;

            foreach(int x in nums)
            {
                if(x==val)
                {
                    found = true;
                    break;
                }
            }

            if(found)
                 Console.Write("Number found");
            else
                Console.Write("Number not found");

            Console.ReadLine();
        }
    }
}
