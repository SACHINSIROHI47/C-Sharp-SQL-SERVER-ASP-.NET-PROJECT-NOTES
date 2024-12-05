using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp290616_E1
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            int []sample = new int[10];
            int i;

            for (i = 0; i < 10; i = i + 1)
                sample[i] = i;

            for (i = 0; i < 10; i = i + 1)
                Console.WriteLine("sample[" + i + "] : " + sample[i]);

            Console.ReadLine();
        }
    }
}
