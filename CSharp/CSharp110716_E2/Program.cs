using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp110716_E2
{
    class ThreeD
    {
        int x, y, z;
        public ThreeD()
        {
            x = y = z = 0;
        }

        public ThreeD(int i, int j, int k)
        {
            x = i;
            y = j;
            z = k;
        }

        //OVERLOAD BOOLEAN <
        public static bool operator <(ThreeD op1, ThreeD op2)
        {
            if (Math.Sqrt(op1.x * op1.x + op1.y * op1.y + op1.z * op1.z) <
                Math.Sqrt(op2.x * op2.x + op2.y * op2.y + op2.z * op2.z))
                return true;
            else
                return false;
        }

        //OVERLOAD BOOLEAN >
        public static bool operator >(ThreeD op1, ThreeD op2)
        {
            if (Math.Sqrt(op1.x * op1.x + op1.y * op1.y + op1.z * op1.z) >
                Math.Sqrt(op2.x * op2.x + op2.y * op2.y + op2.z * op2.z))
                return true;
            else
                return false;
        }

        //OVERLOAD BOOLEAN ==
        public static bool operator ==(ThreeD op1, ThreeD op2)
        {
            if (op1.x == op2.x && op1.y == op2.y && op1.z == op2.z)
                return true;
            else
                return false;
        }
        //OVERLOAD BOOLEAN !=
        public static bool operator !=(ThreeD op1, ThreeD op2)
        {
            if (op1.x != op2.x && op1.y != op2.y && op1.z != op2.z)
                return true;
            else
                return false;
        }

        //Show x y z coordinates
        public void show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ThreeD a = new ThreeD(5, 6,7);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c = new ThreeD(1, 2, 3);
            ThreeD d = new ThreeD(6, 7, 5);

            Console.Write("Here is a: ");
            a.show();
            Console.WriteLine();

            Console.Write("Here is b: ");
            b.show();
            Console.WriteLine();

            Console.Write("Here is c: ");
            c.show();
            Console.WriteLine();

            Console.Write("Here is d: ");
            d.show();
            Console.WriteLine();

            if (a > c)
                Console.WriteLine("a > c is true");
            if (a < c)
                Console.WriteLine("a < c is true");
            if (a > b)
                Console.WriteLine("a > b is true");
            if (a < b)
                Console.WriteLine("a < b is true");
            if (a > d)
                Console.WriteLine("a > d is true");
            else if (a < d)
                Console.WriteLine("a < d is true");
            else
                Console.WriteLine("a and d are same distance from origin");

            Console.WriteLine();

            if (a == b)
                Console.WriteLine("a and b are same distance from origin");
            else
                Console.WriteLine("a and b are not same distance from origin");

            Console.WriteLine();

            if (a != b)
                Console.WriteLine("a and b are not same distance from origin");
            else
                Console.WriteLine("a and b are same distance from origin");

            Console.ReadLine();
        }
    }
}
