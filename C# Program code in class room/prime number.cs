using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        public int x, y, z;
        Program(int a,int b)
        {
            x = a;
            y = b;
            z = x + y;
            Console.WriteLine("Sum of two values :"+z);

        }

        void sum(float f1,float f2)
        {

            float ff1 = f1;
            float ff2 = f2;
            float ff3 = ff1 * ff2;
            Console.WriteLine("Float values :"+ff3);
        }

        public void mytech()
        {
            int j;
            for (j = 1; j <= 5; j++)
            {
                if (j == 4) return;
                Console.WriteLine("Loop");
            }
        }
        public bool IsPrime(int x)
        {
            if (x <= 1) return false;
            for (int i = 2; i <= x / i; i++)
            {
                if((x%i)==0) return false;
                return true;
                
            }
            
        }
        static void Main(string[] args)
        { 
            int a1,b1;
            Console.WriteLine("Enter 1st number");
            int.TryParse(Console.ReadLine(),out a1);
            Console.WriteLine("Enter second number");
            int.TryParse(Console.ReadLine(), out b1); 

            Program op = new Program(a1,b1);
            op.sum(50.22f,60.26f);
            op.mytech();

            int i;
            for (i = 2; i < 10;i++)
            {
                if (op.IsPrime(i))
                {
                    Console.WriteLine(i + "is prime");
                }
                else
                {
                    Console.WriteLine(i + "is not prime");
                }
            }


                Console.ReadLine();


        }
    }
}
