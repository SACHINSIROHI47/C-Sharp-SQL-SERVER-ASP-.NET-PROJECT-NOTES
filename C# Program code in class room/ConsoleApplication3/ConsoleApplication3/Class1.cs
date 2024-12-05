using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Class1
    {
        public int floors, Area, occupants;


        static void Main(string[] args)
        {
            int areapp;
            Class1 aaobj = new Class1();
            aaobj.floors = 100;
            aaobj.Area = 200;
            aaobj.occupants = 300;
            areapp = aaobj.Area / aaobj.occupants;
            Console.WriteLine(areapp);



        }

    }
}
