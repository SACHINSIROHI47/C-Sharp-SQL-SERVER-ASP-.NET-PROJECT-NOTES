using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 
    class Building
    {
        public int Floor;
        public int Area;
        public int Occupants;

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

    //Use Max Occupants
    class BuildingDemo
    {
        static void Main(string[] args)
        {
            Building house = new Building();
            Building office = new Building();

            //Assign values to field in house
            house.Occupants = 4;
            house.Area = 2500;
            house.Floor = 2;

            //Assign values to field in office
            office.Occupants = 25;
            office.Area = 4200;
            office.Floor = 3;

            Console.WriteLine("Maximum Occupants for house if each has 300 square feet: " + house.MaxOccupants(300));

            Console.WriteLine("Maximum Occupants for office if each has 300 square feet: " + office.MaxOccupants(300));

            Console.WriteLine("Area Per Person for house : " + house.AreaPerPerson());

            Console.WriteLine("Area Per Person for office : " + office.AreaPerPerson());

            Console.ReadLine();

 


        }
    }
{
    class Building
    {
        public int Floor;
        public int Area;
        public int Occupants;

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

    //Use Max Occupants
    class BuildingDemo
    {
        static void Main(string[] args)
        {
            Building house = new Building();
            Building office = new Building();

            //Assign values to field in house
            house.Occupants = 4;
            house.Area = 2500;
            house.Floor = 2;

            //Assign values to field in office
            office.Occupants = 25;
            office.Area = 4200;
            office.Floor = 3;

            Console.WriteLine("Maximum Occupants for house if each has 300 square feet: " + house.MaxOccupants(300));

            Console.WriteLine("Maximum Occupants for office if each has 300 square feet: " + office.MaxOccupants(300));

            Console.WriteLine("Area Per Person for house : " + house.AreaPerPerson());

            Console.WriteLine("Area Per Person for office : " + office.AreaPerPerson());

            Console.ReadLine();

 


        }
    }
}
