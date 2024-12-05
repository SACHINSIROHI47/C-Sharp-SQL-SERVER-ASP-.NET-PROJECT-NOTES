using System;
using System.Collections.Generic;
using System.Text;

namespace Demo4
{
    class Demo4
    {
        static void Main(string[] args)
        {
           int nNum, nLarge, nCtr;
		   nCtr = 1; 
           nLarge = 0;
           Console.WriteLine("Enter ten numbers");
		   for (;nCtr <= 10; nCtr++)
           {
 			    nNum=Convert.ToInt32(Console.ReadLine());
  			    if(nNum > nLarge)
                {
  			        nLarge = nNum;
                }
           }
		Console.WriteLine("The largest number is :"+nLarge);
	
 

        }
    }
}
