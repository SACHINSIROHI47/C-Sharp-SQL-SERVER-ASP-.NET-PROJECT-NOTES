using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {

        public bool bfun(int x)
        {
            if (x == 5)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            if (obj.bfun(52))
            {
                Console.WriteLine("Value is equal");
            }
            else
            {
                Console.WriteLine("Value is not equal");
            }
            Console.ReadLine();
        }
    }
}
