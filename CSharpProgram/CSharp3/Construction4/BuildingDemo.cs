using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Construction4
{
    class BuildingDemo
    {
        static void Main(string[] args)
        {

            Building house = new Building();
            Building office = new Building();

            int areaPP;

            //Assign values to field in house
            house.Occupents = 4;
            house.Area = 2500;
            house.Floors = 2;

            //Assign values to field in office
            office.Occupents = 25;
            office.Area = 4200;
            office.Floors = 3;

            areaPP = house.Area / house.Occupents;

            Console.WriteLine("house has :\n" +
                    house.Floors + " floors \n" +
                    house.Occupents + " Occupents \n" +
                    house.Area + " total Area \n" +
                    areaPP + " Area per Person");

            Console.WriteLine("");

            areaPP = office.Area / office.Occupents;

            Console.WriteLine("office has :\n" +
                    office.Floors + " floors \n" +
                    office.Occupents + " Occupents \n" +
                    office.Area + " total Area \n" +
                    areaPP + " Area per Person");

            Console.ReadLine();
        }
    }
}
