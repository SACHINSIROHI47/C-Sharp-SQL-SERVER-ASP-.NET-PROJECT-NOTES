using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp050716_E4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;

            Console.Write("Enter Your name : ");
            str1 = Console.ReadLine();
            Console.Write("Enter Your Friend name : ");
            str2 = Console.ReadLine();

            if (str1.Equals(str2))
            {
                Console.WriteLine(" Your names are same");
            }
            else
            {
                Console.WriteLine(" Your names are not same");
            }
            Console.ReadLine();
        }
    }
}
