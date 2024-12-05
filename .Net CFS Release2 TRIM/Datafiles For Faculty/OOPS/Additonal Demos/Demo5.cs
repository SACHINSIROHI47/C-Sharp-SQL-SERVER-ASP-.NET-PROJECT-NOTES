using System;
using System.Collections.Generic;
using System.Text;

namespace Demo5
{
    class Demo5
    {
        static void Main(string[] args)
        {

            int nNum=0;
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Enter a number");
                nNum = Convert.ToInt32(Console.ReadLine());
                if (nNum % 2 == 0)
                {
                    Console.WriteLine("The number is Even");
                }
                else
                {
                    Console.WriteLine("The number is Odd");
                }

            }

        }
    }
}
