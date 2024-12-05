using System;
using System.Collections.Generic;
using System.Text;

namespace Quotient
{
    class Quotient
    {
        static void Main(string[] args)
        {
            int nNum1, nNum2, nResult;
            Console.WriteLine("Enter the first Number");
            nNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            nNum2 = Convert.ToInt32(Console.ReadLine());
            nResult = nNum1 / nNum2;
            Console.WriteLine("The quotient is :" + nResult);

        }
    }
}
