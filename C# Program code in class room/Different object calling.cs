using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        public int floors, Area, occupants;


        static void Main(string[] args)
        {
            int areapp,areapp2;
            Program aaobj = new Program();
            Program aaobj2 = new Program();
            aaobj.floors = 100;
            aaobj.Area = 2000;
            aaobj.occupants = 300;

            aaobj2.floors = 900;
            aaobj2.Area = 8000;
            aaobj2.occupants = 700;
            
            areapp = aaobj.Area / aaobj.occupants;
            Console.WriteLine(areapp);
            areapp2 = aaobj2.Area / aaobj2.occupants;
            Console.WriteLine(areapp2);
            
            Console.WriteLine("Area1:"+aaobj.Area+"  floor1:"+aaobj.floors+"  occupants"+aaobj.occupants);
            Console.WriteLine("Area2:" + aaobj2.Area + "  floor2:" + aaobj2.floors + "  occupants2" + aaobj2.occupants);

            Console.ReadLine();



        }
    }

}
