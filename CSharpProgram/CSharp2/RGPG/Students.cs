using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RGPG
{
    class Students
    {
        static void Main(string[] args)
        {
            int roll_no;
            String name;
            float fee;
            Console.WriteLine("Enter Roll No. :");
            roll_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            name=Console.ReadLine();
            Console.WriteLine("Enter Fee :");
            fee=(float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Student Details");
            Console.WriteLine("---------------");
            Console.WriteLine("Roll Number is {0}",roll_no);
            Console.WriteLine("Name is {0}", name);
            Console.WriteLine("Fee is {0}", fee);
            Console.ReadLine();

        }
    }
}
