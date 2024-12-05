using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingVaribles
{
    class Program
    {
        static void Main(string[] args)
        {
            char grade = 'B';
            String name = "Bill Gates";
            int age = 26;
            float fee = 5000.45F;
            double total_fee = 85768.765;
            bool selection = true;

            Console.WriteLine("Displaying Variables values");
            Console.WriteLine("----------------");
            Console.WriteLine("Grade is {0}", grade);
            Console.WriteLine("Name is {0}",name);
            Console.WriteLine("Age is {0}",age);
            Console.WriteLine("Fee is {0}",fee);
            Console.WriteLine("Total Fee is {0}",total_fee);
            Console.WriteLine("Selection is {0}",selection);
            Console.WriteLine("----------------");
            Console.WriteLine("Another Methaod");
            Console.WriteLine("----------------");
            Console.WriteLine("Age is");
            Console.WriteLine(age);
            Console.ReadLine();

        }
    }
}
