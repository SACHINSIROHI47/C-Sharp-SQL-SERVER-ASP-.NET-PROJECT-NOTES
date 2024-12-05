using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp120716_E1
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

        //Overload unary operator --
        public static ThreeD operator --(ThreeD op)
        {
            ThreeD result = new ThreeD();
            result.x = op.x - 1;
            result.y = op.y - 1;
            result.z = op.z - 1;
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
            ThreeD a = new ThreeD(5, 6,7);
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

           if (a)
               Console.WriteLine("a is true");
           else
               Console.WriteLine("a is false");
           if (b)
               Console.WriteLine("b is true");
           else
               Console.WriteLine("b is false");
           if (c)
               Console.WriteLine("c is true");
           else
               Console.WriteLine("c is false");

           Console.WriteLine();

            Console.WriteLine("Control a lopp using ThreeD object");
              do
                {
                    b.show();
                    b--;
                }while(b);

            Console.ReadLine();
        }
    }
}
