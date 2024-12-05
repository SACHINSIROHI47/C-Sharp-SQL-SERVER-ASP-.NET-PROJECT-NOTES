using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculation2
{
    class ChkNum
    {
        //return true if x is prime
        public bool IsPrime(int x)
        {
            if(x <= 1)
                return false;

            for(int i=2; i<=x/i; i++)
                if(x%i == 0)
                    return false;

            return true;
        }        
    }

    class ParmDemo
    {
        static void Main(string[] args)
        {
            ChkNum ob = new ChkNum();

                for(int i =2; i < 100; i++)
                if(ob.IsPrime(i))
                    Console.WriteLine(i + " is prime.");
                else
                    Console.WriteLine(i + " is not prime.");

            Console.ReadLine();

        }
    }
}
