using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp220716_E3
{
    class Base
    {
        //Create virtual method in the base class
        public virtual void Who()
        {
            Console.WriteLine("Who() in Base");
        }
    }

    class Derved1 : Base
    {
        //Override Who() in a Derived class
        public override void Who()
        {
            Console.WriteLine("Who() in a Derived1");
        }
    }

    class Derved2 : Base
    {
        //This class does notOverride Who()  
    }

    class OverrideDemo
    {
        static void Main(string[] args)
        {
            Base baseob = new Base();
            Derved1 dob1 = new Derved1();
            Derved2 dob2 = new Derved2();

            Base baseRef;

            baseRef = baseob;
            baseRef.Who();

            baseRef = dob1;
            baseRef.Who();

            baseRef = dob2;
            baseRef.Who();

            Console.ReadLine();


        }
    }
}
