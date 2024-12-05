using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        
        public int x, y;
        public float z;
        Program(int a, float b, int c)
        {            
            this.x = a;
            this.y = c;
            this.z = b;
            
        }
        ~Program()
        {
            //Console.WriteLine("Destructors is call");
            //Console.WriteLine("Destructors is call"+x);

        }
        static void Main(string[] args)
        {
            Program obj = new Program(10,2.5f,6);
            Console.WriteLine(obj.x);
            Console.WriteLine(obj.y);
            Console.WriteLine(obj.z);
            Console.ReadLine();


            


        }
    }
}
