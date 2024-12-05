using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp040716_E1
{
    class Jaged
    {
        static void Main(string[] args)
        {
            var jagged = new []{
                new[] {1,2,3},
                new[] {4,5},
                new[] {6,7,8,9}
            };

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                    Console.Write(jagged[i][j] + " ");

                Console.WriteLine();                
            }
            Console.ReadLine();
        }
    }
}
