using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bike_details
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike object1 = new Bike();
            object1.AcceptBikeDetails();
            object1.DisplayBikeDetails();
            Console.WriteLine("Bye ------\n");
            Console.ReadLine();
        }

    }
        public class bike
        {
            public void AcceptBikeDetails()
            {
                Console.WriteLine("Accepting Bike Details\n");
            }
            public void DisplayBikeDetails()
            {
                Console.WriteLine("Displaying Bike Details\n");


        }
    }
}
