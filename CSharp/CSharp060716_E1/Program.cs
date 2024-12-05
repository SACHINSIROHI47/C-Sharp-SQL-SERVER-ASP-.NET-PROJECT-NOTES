using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp060716_E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int nextdigit;
            int numdigits;

            int[] n = new int[20];

            string[] digits ={"zero","one","two",
                                 "three","four","five",
                                 "six","seven","eight",
                                 "nine" };

            Console.Write("Enter Numbers  : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number : " + num);

            Console.Write("Numbers in words : ");

            nextdigit = 0;
            numdigits = 0;

            do
            {
                nextdigit = num % 10;
                n[numdigits] = nextdigit;

                numdigits++;

                num = num / 10;
            } while (num > 0);

            numdigits--;

            for(;numdigits>=0;numdigits--)
                Console.Write(digits[n[numdigits]] + " ");


            Console.WriteLine();

            Console.ReadLine();


        }
    }
}
