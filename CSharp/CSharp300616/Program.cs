using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp300616
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] sqrs ={
                              {1, 1},
                              {2, 4},
                              {3, 9},
                              {4, 16}
                          };
            int i, j;

            for(i = 0; i < 4; i++)
            {
                for(j = 0; j < 2; j++)
                {
                        Console.Write(sqrs[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
