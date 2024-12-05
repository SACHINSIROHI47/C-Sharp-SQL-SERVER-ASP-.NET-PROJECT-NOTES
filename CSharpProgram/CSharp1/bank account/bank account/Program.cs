using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bank_account
{
    class Program
    {
        static void Main(string[] args)
        {
            int acno;
            string first_name;
            string last_name;
            string address;
            float balance;

            Console.WriteLine("Enter acno  :");
            acno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Name :");
            first_name = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            last_name = Console.ReadLine();
            Console.WriteLine("Enter address:");
            address = Console.ReadLine();
            Console.WriteLine("Enter Balance:");
            balance = (float)Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Customer details    :");
            Console.WriteLine("  ");
            Console.WriteLine("-------------------");
            Console.WriteLine("First Name is {0}",first_name);
            Console.WriteLine("Last Name is {0}", last_name);
            Console.WriteLine("Address is {0}", address);
            Console.WriteLine("Balance is {0}", balance);
            Console.ReadLine();


        }
    }
}
