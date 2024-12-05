using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp280616_E5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integer Array
            int[] array1 = new int[4];

            array1[0] = 10; 
            array1[1] = 20;
            array1[2] = 30;
            array1[3] = 40;

            Console.WriteLine("Integer Array");
            Console.WriteLine(array1[0]);
            Console.WriteLine(array1[1]);
            Console.WriteLine(array1[2]);
            Console.WriteLine(array1[3]);

            //Float Array
            float[] array2 = new float[4];

            array2[0] = 10.78F;
            array2[1] = 20.75F;
            array2[2] = 30.11F;
            array2[3] = 40.38F;

            Console.WriteLine();
            Console.WriteLine("Float Array");
            Console.WriteLine(array2[0]);
            Console.WriteLine(array2[1]);
            Console.WriteLine(array2[2]);
            Console.WriteLine(array2[3]);

            //string Array
            string[] array3 = new string[4];

            array3[0] = "Mikal";
            array3[1] = "Ramesh";
            array3[2] = "Sangeeta";
            array3[3] = "Maria";

            Console.WriteLine();
            Console.WriteLine("String Array");
            Console.WriteLine(array3[0]);
            Console.WriteLine(array3[1]);
            Console.WriteLine(array3[2]);
            Console.WriteLine(array3[3]);

            Console.ReadLine();
        }
    }
}
