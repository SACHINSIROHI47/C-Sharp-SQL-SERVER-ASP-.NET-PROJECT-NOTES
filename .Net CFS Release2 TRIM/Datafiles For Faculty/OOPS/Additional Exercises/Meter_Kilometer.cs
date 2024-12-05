using System;
using System.Collections.Generic;
using System.Text;

namespace Quotient
{
    class Meter_Kilometer
    {
        static void Main(string[] args)
        {
            int nDistance, nResult;
            Console.WriteLine("Enter the distance in kilometers");
            nDistance = Convert.ToInt32(Console.ReadLine());
            nResult = nDistance * 1000;
            Console.WriteLine("Distance in meters:" + nResult);


        }
    }
}
