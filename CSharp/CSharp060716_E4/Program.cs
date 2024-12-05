using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp060716_E4
{
    class ThreeD
    {
        int x, y, z;
        public ThreeD()
        {
            x = y = z = 0;
        }

        public ThreeD(int i,int j, int k)
        {
            x = i;
            y = j;
            z = k;

        }

        //OVERLOAD BINARY +
        public static ThreeD operator + (ThreeD op1,ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1.x + op2.x;
            result.y = op1.y + op2.y;
            result.z = op1.z + op2.z;
            return result;
        }

        //OVERLOAD BINARY -
        public static ThreeD operator -(ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1.x - op2.x;
            result.y = op1.y - op2.y;
            result.z = op1.z - op2.z;
            return result;
        }

        //Show x y z coordinates
        public void show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
    }
    class ThreeDDemo
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

            c = a + b; //add a and b together
            Console.Write("Result of a + b: ");
            c.show();
            Console.WriteLine();

            c = a + b + c; //add a,b  and c together
            Console.Write("Result of a + b + c: ");
            c.show();
            Console.WriteLine();

            c = c - a; //subtract 1
            Console.Write("Result of c - a: ");
            c.show();
            Console.WriteLine();

            c = c - b; //subtract b
            Console.Write("Result of c - b: ");
            c.show();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
