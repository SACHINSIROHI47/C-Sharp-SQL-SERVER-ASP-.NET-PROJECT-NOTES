using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS270616_E5
{
    class Building
    {
        public int Floor;
        public int Area;
        public int Occupants;

        //Constructor
        public Building(int f, int a, int o)
        {
             Floor = f;
             Area = a;
             Occupants = o;
        }

        //return the Area per Person
        public int AreaPerPerson()
        {
            return Area / Occupants;
        }

        //Return the maximum number of Occupants if each
        //is to have at least the specifiaed minimum area
        public int MaxOccupants(int minArea)
        {
            return Area / minArea;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Building house = new Building(2, 2500, 4);
            Building office = new Building(3, 4200, 25);

            Console.WriteLine("Maximum Occupants for house if each has 300 square feet: " + house.MaxOccupants(300));

            Console.WriteLine("Maximum Occupants for office if each has 300 square feet: " + office.MaxOccupants(300));

            Console.ReadLine();
        }
    }
}
