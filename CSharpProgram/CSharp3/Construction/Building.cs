using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Construction
{
    class Building
    {
        public int Floors;
        public int Area;
        public int Occupents;
        static void Main(string[] args)
        {
            Building house = new Building();
            int areaPP;
            house.Occupents = 4;
            house.Area = 2500;
            house.Floors = 2;

            areaPP = house.Area / house.Occupents;

            Console.WriteLine("house has :\n" +
                    house.Floors + " floors \n" +
                    house.Occupents + " Occupents \n" +
                    house.Area + " total Area \n" +
                    areaPP + " Area per Person");
            Console.ReadLine();   
        }
    }
}
