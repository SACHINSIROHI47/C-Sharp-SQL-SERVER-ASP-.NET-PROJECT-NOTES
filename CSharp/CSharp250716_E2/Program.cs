using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp250716_E2
{
    sealed class B
    {
        public void MyMethod()
        {
            Console.WriteLine("Welcome to class B");
        }
    }
    class D
    {
        public virtual void MyMethod()
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
            D ob2 = new D();
            D ob3 = new X();

            ob1.MyMethod();
            ob2.MyMethod();
            ob3.MyMethod();

            Console.ReadLine();
        }
    }
}
