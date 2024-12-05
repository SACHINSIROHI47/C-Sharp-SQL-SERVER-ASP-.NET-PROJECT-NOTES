using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        public void forlp()
        {
            int a;
            for (a = 1; a <= 10; a++)
            {
                Console.WriteLine("2*" + a + "=" + a * 2);

            }

        }
        public void whilelp()
        {
            int w=1;
            while(w<5)
            {
                Console.WriteLine("variable looping"+w);
                w++;
            }
        }
        public void dowhilelp()
        {
            int wd=50;

            do
            {
                Console.WriteLine("Do while loop "+wd);
                wd++;
            }
            while(wd<5);

        }
          
        static void Main(string[] args)
        {
            Program obj=new Program();
            obj.forlp();
            obj.whilelp();
            obj.dowhilelp();
            
            Console.ReadKey();

        }
      
    }
}
