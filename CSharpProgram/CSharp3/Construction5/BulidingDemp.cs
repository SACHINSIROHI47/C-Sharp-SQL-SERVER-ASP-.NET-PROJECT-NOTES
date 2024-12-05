using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Construction5
{
    class Building
    {
        public int Floors;
        public int Area;
        public int Occupents;
    }
    class BulidingDemp
    {
        static void Main(string[] args)
        {
            Building house = new Building();
            Building office = house;

            int areaPP;

            //Assign values to field in house
            house.Occupents = 4;
            house.Area = 2500;
            house.Floors = 2;
            
            areaPP = house.Area / house.Occupents;

            Console.WriteLine("house has :\n" +
                    house.Floors + " floors \n" +
                    house.Occupents + " Occupents \n" +
                    house.Area + " total Area \n" +
                    areaPP + " Area per Person");

            Console.WriteLine("");          

            Console.WriteLine("office has :\n" +
                    office.Floors + " floors \n" +
                    office.Occupents + " Occupents \n" +
                    office.Area + " total Area \n" +
                    areaPP + " Area per Person");

            Console.ReadLine();
        }
    }
}
