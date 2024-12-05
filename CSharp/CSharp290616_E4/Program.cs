using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp290616_E4
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, i;
            int[,] table = new int[3, 4];

            for (t = 0; t < 3; t = t + 1)
            {
                for (i = 0; i < 4; ++i)
                {
                    table[t, i] = (t * 4) + i + 1;
                    Console.Write(table[t, i] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
