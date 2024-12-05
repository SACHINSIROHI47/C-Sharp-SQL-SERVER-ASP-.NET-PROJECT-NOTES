using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bannking
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts object1 = new Accounts();
            Accounts object2 = new Accounts();
            object1.accept();
            object1.balance = 1500;
            object2.accept();
            object1.display();
            object2.display();
            Console.ReadLine();
        }
    }
    public class Accounts
    {
        int acno;
        String name;
        public float balance;
        public void accept()
        {
            Console.WriteLine("Enter Account Number : ");
            acno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Balance : ");
            balance = (float)Convert.ToDecimal(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Account Number is {0}",acno);
            Console.WriteLine("Name is {0}",name);
            Console.WriteLine("Balance is {0}",balance);
            
        }
    }

}
