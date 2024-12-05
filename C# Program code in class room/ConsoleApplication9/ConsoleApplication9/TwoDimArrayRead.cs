using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class TwoDimArrayRead
    {
      

        public void ary()
        {
            int[] towread = new int[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter value for Array");
                int.TryParse(Console.ReadLine(), out towread[i]);
            }
            for (int j = 0; j < 2; j++)
            {
                Console.Write(towread[j] + "\t");
            }
        }
        public void ary2()
        {

            int[,] towread2 = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter value for Array");
                    int.TryParse(Console.ReadLine(), out towread2[i, j]);
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(towread2[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }


        }
        public void frech()
        {
            int[] num =new int[5]{50,100,1,300,400};
            foreach (int x in num)
            {
                Console.WriteLine(x);
                if (x == 1)
                    break;
            }
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine("For Loop: "+a);
                continue;
                Console.WriteLine("For Loop Continue");
                if (a == 5)
                    break;
               
            }
        }
    }

}