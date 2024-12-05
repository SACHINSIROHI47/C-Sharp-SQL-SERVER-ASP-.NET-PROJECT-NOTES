using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Construction8
{
    class Building
    {
        public int Floors;
        public int Area;
        public int Occupants;

        //Returns the area per person
        public int AreaPerPerson()
        {
            return Area / Occupants;
        }
    }
    class BuildingDemo
    {
        static void Main(string[] args)
        {
            Building house = new Building();
            Building office = new Building();
     
            // Assign values to fields in house
            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            // Assign values to fields in house
            office.Occupants = 25;
            office.Area = 4200;
            office.Floors = 3;

            //obtain arear per oerson for house
          
            Console.WriteLine("House hase:\n " +
                house.Floors + " floors\n" +
                house.Occupants + " occupants\n" +
                house.Area + " total area\n" +
                house.AreaPerPerson() + " area per person\n");

            Console.WriteLine();
                      
            Console.WriteLine("Office hase:\n " +
                office.Floors + " floors\n" +
                office.Occupants + " occupants\n" +
                office.Area + " total area\n" +
                office.AreaPerPerson() + " area per person\n");

            Console.ReadLine();


        }
    }
}
