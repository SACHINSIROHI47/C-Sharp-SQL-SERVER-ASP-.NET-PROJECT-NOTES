using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS270616_E3
{
    class Program
    {
        public void MyMath()
        {
            char a, b;
            Console.Write("Enter First Character : ");
            a = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter Second Character : ");
            b = Convert.ToChar(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("equal");
                //return;
            }
            else
            {
                Console.WriteLine("not equal");
                //return;
            }

            Console.WriteLine("This is Unreachable");
            Console.WriteLine("Press Enter to Contnue");
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            Program object1 = new Program();
            object1.MyMath();
        }
    }
}
