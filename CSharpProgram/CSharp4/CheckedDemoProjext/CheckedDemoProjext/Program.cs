using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckedDemoProjext
{
    class CheckedDemo
    {
        static void Main(string[] args)
        {
            byte a, b;
            byte result;

            a = 127;
            b = 127;

            try
            {
                result = unchecked((byte)(a * b));
                Console.WriteLine("Uncheked result: " + result);

                result = unchecked((byte)(a * b));
                Console.WriteLine("Cheked result: " + result);
            }
            catch(OverflowException exc)
            {
                Console.WriteLine(exc);
            }
            Console.ReadLine();
        }
    }
}
