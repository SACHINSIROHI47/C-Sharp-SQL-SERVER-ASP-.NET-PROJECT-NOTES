using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {

        public int x, y, z;


        public Program()
        {
            x = y = z = 0;
        }
        public Program(int i, int j, int k)
        {
            x = i;
            y = j;
            z = k;
        }
        public static Program operator +(Program obj1, Program obj2)
        {
            Program result = new Program();
            result.x = obj1.x + obj2.x;
            result.y = obj1.y + obj2.y;
            result.z = obj1.z + obj2.z;
            return result;
            
        }
        public static Program operator -(Program obj1, Program obj2)
        {
            Program result = new Program();
            result.x = obj1.x - obj2.x;
            result.y = obj1.y - obj2.y;
            result.z = obj1.z - obj2.z;
            return result;
        }
        public static Program operator ++ (Program obj3)
        {
            Program result = new Program();
            result.x = obj3.x + 1;
            result.y = obj3.y + 1;
            result.z = obj3.z + 1;
            return result;
        }
        public static Program operator --(Program obj3)
        {
            Program result = new Program();
            result.x = obj3.x - 2 ;
            result.y = obj3.y - 2;
            result.z = obj3.z - 2;
            return result;
        }
        public static Program operator +(Program obj1, int a1)
        {
            Program result = new Program();
            result.y = obj1.y + a1;
            return result;
        }
        public void show()
        {
            Console.WriteLine(x+" "+y+" "+z);
            
        }
        static void Main(string[] args)
        {
            Program a = new Program(1,2,3);
            Program b = new Program(10, 10, 10);
            Program c;
            Program d;
            Console.Write("Here is a :");
            a.show();
            Console.WriteLine();
            b.show();
            Console.WriteLine();
            c = a + b;
            Console.Write("Result of a + b:");
            c.show();
            Console.WriteLine();
            c = a + b + c;
            Console.Write("Result of a + b + c:");
            c.show();
            Console.WriteLine();
            c = c - a;
            Console.Write("Result of c- a: ");
            c.show();
            Console.WriteLine();
            d = ++a;
            Console.Write("Result of Unary(++) operator: ");
            d.show();
            Console.WriteLine();
            d = --b;
            Console.Write("Result of Unary(--) operator: ");
            d.show();

            Console.WriteLine();
            d=b+3;
            Console.Write("Result of / operator: ");
            d.show();
            Console.ReadLine();
            
            
        }



        }
    }

