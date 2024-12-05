using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        public static float pr,result;
        public float price()
        {
            result = 125.64f;
            pr = result + 10;
            return pr; 

         }

        public float disp()
        {
            float rs = pr + 20;
            Console.WriteLine("Display  "+rs);
            return 0;
        }

        static void Main(string[] args)
        {
            Program pp = new Program();
            pp.price();
            pp.disp();           
            Console.WriteLine(pr);
            Console.ReadLine();
            
        }
    }
}
