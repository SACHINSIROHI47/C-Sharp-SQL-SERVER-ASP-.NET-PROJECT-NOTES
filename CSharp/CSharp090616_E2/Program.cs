using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp090616_E2
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

        //OVERLOAD BINARY +
        public static ThreeD operator +(ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1.x + op2.x;
            result.y = op1.y + op2.y;
            result.z = op1.z + op2.z;
            return result;
        }

        //OVERLOAD BINARY +
        public static ThreeD operator +(ThreeD op1, int op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1.x + op2;
            result.y = op1.y + op2;
            result.z = op1.z + op2;
            return result;
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
            ThreeD a = new ThreeD(1, 2, 3);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c;

            Console.Write("Here is a: ");
            a.show();
            Console.WriteLine();

            Console.Write("Here is b: ");
            b.show();
            Console.WriteLine();

            c = a + b; //ThreeD + ThreeD
            Console.Write("Result of a + b: ");
            c.show();
            Console.WriteLine();

            c = b + 15; //ThreeD + int
            Console.Write("Result of b + 15: ");
            c.show();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
