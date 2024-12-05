using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            char choice = 'y';
            string str = "hello word";
            float price = 45.55456456f;
            double price2 = 56.4585867d;
            Boolean bl = false;

            Console.WriteLine("Number is: "+number);
            Console.WriteLine("Number is: " + number);
            Console.WriteLine("Character Value: " + choice);
            Console.WriteLine("Strings are: " + str);
            Console.WriteLine("float values is:" + price);
            Console.WriteLine("Double values is:" + price2);
            Console.WriteLine("boolean values :" + bl);
            Console.ReadLine();//this is use to stay a screen
        }
    }
}
