using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class ThreeDimArray
    {
        public void threary()
        {
            int[, ,] multary = new int[4, 4, 4];
            //int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        //sum = multary[0, 0, 0] + multary[1, 1, 1];
                        Console.Write(1+k+" ");
                    }

                } Console.WriteLine("\n");
            }
          }
        public void arrlength()
        {
            int[] aary={20,30,40};

            for (int i = 0; i < aary.Length; i++)
            {
                Console.WriteLine(aary[i]);
            }

        }

    }
}
