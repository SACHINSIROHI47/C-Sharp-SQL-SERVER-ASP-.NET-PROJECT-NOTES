using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp020816_E7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };

            for (int i = 0; i < numer.Length; i++)
            {
                try
                {
                    Console.WriteLine(numer[i] + "/" + denom[i] +
                       " is " + numer[i] / denom[i]);
                }
                catch (Exception obj)
                {
                    Console.WriteLine("Some Exception occured");
                    Console.WriteLine(obj.Message);
                }
               
            }
            Console.WriteLine("After catch block");
            Console.ReadLine();
        }
    }
}


