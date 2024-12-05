using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char []name = new char[5];
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine().ToCharArray();
            String strName = new String(name);
            Console.WriteLine("Name is {0}", strName);
            Console.ReadLine();
        }
    }
}
