using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp280616_E2
{
    class Destruct
    {
        public int x;

        public Destruct(int i)
        {
            x = i;
            Console.WriteLine("Constructing " + x);
        }

        ~Destruct()
        {
            Console.WriteLine("Destructing " + x);
            Console.ReadLine();
        }

        public void Generator(int i)
        {
            Destruct o = new Destruct(i);
        }

    }
    class DestructDemo
    {
        static void Main(string[] args)
        {
            int count;
            Destruct ob = new Destruct(0);

            for (count = 1; count < 100000; count++)
                ob.Generator(count);

            Console.WriteLine("Done");

            Console.ReadLine();
        }
    }
}
