using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VariableInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            char grade;
            String name;
            int age;
            float fee;
            double total_fee;
            bool selection ;

            Console.WriteLine("Enter Variables values");
            Console.WriteLine("----------------");
            Console.Write("Enter Grade : ");
            grade=Convert.ToChar(Console.ReadLine());
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Fee : ");
            fee = (float)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Total Fee : ");
            total_fee = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Selection : ");
            selection = Convert.ToBoolean(Console.ReadLine());
            
            Console.WriteLine("Displaying Variables values");
            Console.WriteLine("----------------");
            Console.WriteLine("Grade is {0}", grade);
            Console.WriteLine("Name is {0}", name);
            Console.WriteLine("Age is {0}", age);
            Console.WriteLine("Fee is {0}", fee);
            Console.WriteLine("Total Fee is {0}", total_fee);
            Console.WriteLine("Selection is {0}", selection);
            Console.WriteLine("----------------");
            Console.WriteLine("Another Methaod");
            Console.WriteLine("----------------");
            Console.WriteLine("Age is");
            Console.WriteLine(age);
            Console.WriteLine("Name is {0} and Age is {1}",name,age);
            Console.ReadLine();
        }
    }
}
