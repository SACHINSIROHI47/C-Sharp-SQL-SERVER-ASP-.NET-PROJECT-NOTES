using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp200716_E5
{
    class A
    {
        public A()
        {
            Console.WriteLine("Constructing A");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("Constructing B");
        }
    }

    class C : B
    {
        public C()
        {
            Console.WriteLine("Constructing C");
        }
    }
    class OrderOfConstruction
    {
        static void Main(string[] args)
        {
            C c = new C();

            Console.ReadLine();
        }
    }
}
