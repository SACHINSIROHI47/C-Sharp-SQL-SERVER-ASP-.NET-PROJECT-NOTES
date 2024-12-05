using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp250716_E1
{
    class B
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("Welcome to class B");
        }
    }
    class D : B
    {
        public override void MyMethod()
        {
            Console.WriteLine("Welcome to class D");
        }
    }
    class X : D
    {
        public override void MyMethod()
        {
            Console.WriteLine("Welcome to class X");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B ob1 = new B();
            B ob2 = new D();
            B ob3 = new X();

            ob1.MyMethod();
            ob2.MyMethod();
            ob3.MyMethod();

            Console.ReadLine();
        }
    }
}
