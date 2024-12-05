using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1
{
    class Demo1
    {
        static void Main(string[] args)
        {
            
            int nNum1,nNum2,nNum3, nNum4, nNum5,nSum, nAverage;
            Console.WriteLine("Enter the five numbers");
            nNum1=Convert.ToInt32(Console.ReadLine());
            nNum2=Convert.ToInt32(Console.ReadLine());
            nNum3=Convert.ToInt32(Console.ReadLine());
            nNum4=Convert.ToInt32(Console.ReadLine());
            nNum5=Convert.ToInt32(Console.ReadLine());
            nSum = nNum1 + nNum2 + nNum3 + nNum4 + nNum5;
            nAverage = nSum / 5;
            Console.WriteLine("Sum= " + nSum);
            Console.WriteLine("Average= " + nAverage);
  

        }
    }
}
