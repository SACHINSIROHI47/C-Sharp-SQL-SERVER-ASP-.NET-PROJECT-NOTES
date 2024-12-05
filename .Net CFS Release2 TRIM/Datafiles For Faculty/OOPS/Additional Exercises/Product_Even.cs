using System;
using System.Collections.Generic;
using System.Text;

namespace Divisible
{
    class Product_Even
    {
        static void Main(string[] args)
        {
            int nNum, nProd, nEven;
            nNum = 2; nEven = 0; nProd = 1;
            while (nEven < 20)
            {
 	            nProd = nNum * nProd;
  	            nNum = nNum + 2;
  	            nEven = nEven + 1;
            }
            Console.WriteLine(nProd);

        }
    }
}
