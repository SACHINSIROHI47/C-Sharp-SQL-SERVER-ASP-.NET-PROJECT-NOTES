using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rgpg1
{
    class Student1
    {
        static void Main(string[] args)
        {
            int roll_no;
            String name;
            float fee;
            Console.WriteLine("Enter Roll no:");
            roll_no=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter fee:  ");
            fee = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(" ");
            Console.ReadLine();

            Console.WriteLine("STUDENT DETAILS");
            Console.WriteLine("--------------------");
            Console.WriteLine("Roll number is {0}",roll_no);
            Console.WriteLine("Name is {0}",name);
            Console.WriteLine("Fee is {0}",fee);
        }
    }
}
