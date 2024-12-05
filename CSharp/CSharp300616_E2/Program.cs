using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp300616_E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [][]jagged = new int[3][];
            jagged[0] =new int[3];
            jagged[1] = new int[2];
            jagged[2] = new int[4];

            int i;

            //Store value in first array
            for (i = 0; i < 3; i++)
                jagged[0][i] = i;

            //Store value in second array
            for (i = 0; i < 2; i++)
                jagged[1][i] = i;

            //Store value in third array
            for (i = 0; i < 4; i++)
                jagged[2][i] = i;

            //Display value in first array
            for (i = 0; i < 3; i++)
                Console.Write(jagged[0][i] + " ");

            Console.WriteLine();

            //Display value in second array
            for (i = 0; i < 2; i++)
                Console.Write(jagged[1][i] + " ");

            Console.WriteLine();

            //Display value in third array
            for (i = 0; i < 4; i++)
                Console.Write(jagged[2][i] + " ");

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
