using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class MultiArray
    {

        public void multary()
        {
            int[ , ] multary=new int[3,3]{{10,20,16},
                                           {30,40,17},
                                           {50,60,18}};

             Console.WriteLine("Multi Array: "+multary[1,1]);
             for (int i = 0; i < 3; i++)
             {
                 for (int j =0 ; j < 3; j++)
                 {
                     Console.Write(multary[i,j]+" ");
                 }
                 Console.WriteLine("\n");
             }

        }

    }
}
