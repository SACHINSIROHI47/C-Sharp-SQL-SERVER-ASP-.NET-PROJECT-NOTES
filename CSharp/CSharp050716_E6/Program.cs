using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp050716_E6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "This", "is", "a", "test." };
            Console.WriteLine("Original Array: ");
            for(int i=0;i<str.Length;i++)
                Console.Write(str[i] + " ");
            Console.WriteLine("\n");

            str[1]="was";
            str[3]="test, tool";

            Console.WriteLine("Modified Array: ");
            for(int i=0;i<str.Length;i++)
                Console.Write(str[i] + " ");
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
