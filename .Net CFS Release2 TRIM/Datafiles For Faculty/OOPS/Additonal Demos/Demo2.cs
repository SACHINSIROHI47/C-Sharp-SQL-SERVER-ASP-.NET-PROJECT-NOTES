using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2
{
    class Demo2
    {
        static void Main(string[] args)
        {
    
            int nNum1, nNum2, nNum3;
        Console.WriteLine("Enter three numbers");
        nNum1=Convert.ToInt32(Console.ReadLine());
        nNum2=Convert.ToInt32(Console.ReadLine());
        nNum3=Convert.ToInt32(Console.ReadLine());
          if ((nNum1 > nNum2) && (nNum1 > nNum3))
          {
            Console.WriteLine(nNum1 +"is the largest number");
          }
        else if ((nNum2 > nNum1) && (nNum2 > nNum3))
        {
            Console.WriteLine(nNum2 +"is the largest number");
        }
        else
        {
            Console.WriteLine(nNum3 +"is the largest number");
        }
    
         }
    }
}
