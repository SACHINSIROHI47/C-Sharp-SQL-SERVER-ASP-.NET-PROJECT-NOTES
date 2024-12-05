using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp130716_E2
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

        //Overload binary operator +
        public static ThreeD operator +(ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1.x + op2.x;
            result.y = op1.y + op2.y;
            result.z = op1.z + op2.z;
            return result;
        }

        //an implicit conversion from Threed to int
         public static implicit operator int(ThreeD op1)
        {
            return op1.x + op1.y + op1.z;
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
            ThreeD c = new ThreeD();

            int i;

            Console.Write("Here is a: ");
            a.show();
            Console.WriteLine();

            Console.Write("Here is b: ");
            b.show();
            Console.WriteLine();

            c = a + b;
            Console.Write("Result of a + b: ");
            c.show();
            Console.WriteLine();

            i = a;
            Console.Write("Result of i = a: " + i);
            Console.WriteLine();

            i = a + 2 - b;
            Console.Write("Result of a + 2 - b: " + i);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
