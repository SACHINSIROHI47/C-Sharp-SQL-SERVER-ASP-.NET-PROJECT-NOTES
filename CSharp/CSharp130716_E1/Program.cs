﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp130716_E1
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

        //OVERLOAD |
        public static ThreeD operator |(ThreeD op1, ThreeD op2)
        {
            if ((op1.x != 0) || (op1.y != 0) || (op1.z != 0) |
                (op2.x != 0) || (op2.y != 0) || (op2.z != 0))
                return new ThreeD(1, 1, 1);  //atlest one cordinate is non zero
            else
                return new ThreeD(0, 0, 0);
        }

        //OVERLOAD &
        public static ThreeD operator &(ThreeD op1, ThreeD op2)
        {
            if ((op1.x != 0) && (op1.y != 0) && (op1.z != 0) &
                (op2.x != 0) && (op2.y != 0) && (op2.z != 0))
                return new ThreeD(1, 1, 1);  //atlest one cordinate is non zero
            else
                return new ThreeD(0, 0, 0);
        }        

        //OVERLOAD !
        public static bool operator !(ThreeD op)
        {
            if (op.x != 0 || op.y != 0 || op.z != 0)
                return false;  //atlest one cordinate is non zero
            else
                return true;
        }

        //OVERLOAD true
        public static bool operator true(ThreeD op)
        {
            if ((op.x != 0) || (op.y != 0) || (op.z != 0))
                return true;  //atlest one cordinate is non zero
            else
                return false;
        }

        //OVERLOAD false
        public static bool operator false(ThreeD op)
        {
            if ((op.x == 0) && (op.y == 0) && (op.z == 0))
                return true;  //all cordinate are non zero
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

            ThreeD a = new ThreeD(5, 6, 7);
            ThreeD b = new ThreeD(4, 4, 4);
            ThreeD c = new ThreeD(0, 0, 0);

            Console.Write("Here is a: ");
            a.show();
            Console.WriteLine();

            Console.Write("Here is b: ");
            b.show();
            Console.WriteLine();

            Console.Write("Here is c: ");
            c.show();
            Console.WriteLine();

            if (!a)
                Console.WriteLine("a is false");
            if (!b)
                Console.WriteLine("b is false");
            if (!c)
                Console.WriteLine("c is false");

            Console.WriteLine();

            if (a & b)
                Console.WriteLine("a & b is true");
            else
                Console.WriteLine("a & b is false");

            if (a & c)
                Console.WriteLine("a & c is true");
            else
                Console.WriteLine("a & c is false");

            if (a | b)
                Console.WriteLine("a | b is true");
            else
                Console.WriteLine("a | b is false");

            if (a | c)
                Console.WriteLine("a | c is true");
            else
                Console.WriteLine("a | c is false");

            Console.WriteLine();

            //Use Short Circuit Operator
            Console.WriteLine("Use Short Circuit Operator && and ||");
            if (a && b)
                Console.WriteLine("a && b is true");
            else
                Console.WriteLine("a && b is false");

            if (c && a)
                Console.WriteLine("a && c is true");
            else
                Console.WriteLine("a && c is false");

            if (a || b)
                Console.WriteLine("a || b is true");
            else
                Console.WriteLine("a || b is false");

            if (c || a)
                Console.WriteLine("a || c is true");
            else
                Console.WriteLine("a || c is false");

            Console.ReadLine();
        }
    }
}