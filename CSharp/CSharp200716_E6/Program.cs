using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp200716_E6
{
    class X
    {
        int a;

        public X(int i)
        {
            a = i;
        }
    }

    class Y
    {
        int a;

        public Y(int i)
        {
            a = i;
        }
    }
    class InCompatibleRef
    {
        static void Main(string[] args)
        {
            X x = new X(10);

            Y x2;

            Y y = new Y(5);

            x2 = x;
            x2 = y;

            Console.ReadLine();
        }
    }
}
