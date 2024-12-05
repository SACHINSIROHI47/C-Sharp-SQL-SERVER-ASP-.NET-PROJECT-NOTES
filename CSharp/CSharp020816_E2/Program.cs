﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp020816_E2
{
    class ExecTest
    {
        //Generate an Exception
        public static void GenException()
        {
            int[] nums = new int[4];
            Console.WriteLine("Before exception is generated");
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
                Console.WriteLine("nums[{0}] : {1}", i, nums[i]);
            }
            Console.WriteLine("this won't be displayed");
        }
    }
    class ExecDemo2
    {
        static void Main(string[] args)
        {
            try
            {
                ExecTest.GenException();
            }
            catch (IndexOutOfRangeException obj)
            {
                Console.WriteLine("index-out-of-bounds");
                Console.WriteLine(obj.Message);
            }
            Console.WriteLine("After catch block");
            Console.ReadLine();
        }
    }
}