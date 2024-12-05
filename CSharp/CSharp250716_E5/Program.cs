using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp250716_E5
{
    class MyClass
    {
        public int num;
        public MyClass()
        {
            Console.WriteLine("Constructor has been called");
        }
        public ~MyClass()
        {
            Console.WriteLine("Destructor has been called");
           
        }
        protected void Finalize()
        {

        }
        public void Show1()
        {
            Console.WriteLine("Number is " + num);
        }
    }
    class YourClass
    {
        public int num;
        public void Show2()
        {
           Console.WriteLine("Number is " + num);
        }
    }
    class TestClass
    {
        static void Main(string[] args)
        {
            MyClass ob1 = new MyClass();
            MyClass ob2 = new MyClass();

            YourClass ob3 = new YourClass();

            ob1.num = 10;
            ob2.num = 20;

            ob3.num = 30;

            if (ob1.Equals(ob2))
            {
                Console.WriteLine("Both objects are from same class");
            }
            else
            {
                Console.WriteLine("Both objects are not from same class");
            }

            Console.WriteLine();
       

           if(Equalssobjects(ob1,ob2))
            {
                Console.WriteLine("Both objects are from same class");
            }
            else
            {
                Console.WriteLine("Both objects are not from same class");
            }

            Console.WriteLine("Has Code : " + ob1.GetHashCode());

            Console.WriteLine();

            Console.WriteLine("Type : " + ob1.GetType());

            Console.WriteLine();

            MyClass ob4;
            ob4 = ob1;
           // MemberwiseClone()
            if (ReferenceEquals(ob1,ob4))
            {
                Console.WriteLine("Both objects Reference are Equals");
            }
            else
            {
                Console.WriteLine("Both objects Reference are not Equals");
            }

            Console.WriteLine();

            Console.WriteLine("String : " + ob1.ToString());


            Console.ReadLine();

        }
    }
}
