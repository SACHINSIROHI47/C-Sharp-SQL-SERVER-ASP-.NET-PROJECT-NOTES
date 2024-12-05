using System;
using System.Collections.Generic;
using System.Text;

namespace Demo3
{
    class Demo3
    {
        static void Main(string[] args)
        {
            int nNum;
            Console.WriteLine("Enter a number");
            nNum=Convert.ToInt32(Console.ReadLine());
            if (nNum % 5 == 0)
            {
                Console.WriteLine("The number is divisible by 5");
            }
            else
            {
                Console.WriteLine("The number is not divisible by 5");
            }
	

        }
    }
}
