using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp200716_E7
{
    class X
    {
        public int a;

        public X(int i)
        {
            a = i;
        }
    }

    class Y : X
    {
        public int b;

        public Y(int i,int J) : base(J)
        {
            b = i;
        }
    }
    class InCompatibleRef
    {
        static void Main(string[] args)
        {
            X x = new X(10);

            X x2;

            Y y = new Y(5, 6);

            x2 = x; //ok both of same type;

            Console.WriteLine("x2.a :" + x2.a);

            x2 = y; //ok y is derived fron x
            Console.WriteLine("x2.a :" + x2.a);


            x2.a = 15;
            Console.WriteLine("x2.a :" + x2.a);

            x2.b = 2;

            Console.ReadLine();
        }
    }
}