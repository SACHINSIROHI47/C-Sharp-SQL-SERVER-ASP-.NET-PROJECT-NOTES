using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckAge
{
    class Voting
    {
        public bool CheckAge(int num)
        {
            if (num >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class DemoChackAge
    {
        static void Main(string[] args)
        {
            int age;
            Voting obj1 = new Voting();

            Console.WriteLine("Enter Age");
            age = Convert.ToInt32(Console.ReadLine());
            if(obj1.CheckAge(age))
            {
                Console.WriteLine("You are eligible for Voting");
            }
            else
            {
                Console.WriteLine("You are not eligible for Voting");
            }

            Console.ReadLine();
        }
    }
}
