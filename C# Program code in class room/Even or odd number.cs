using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {

        public void even_odd()
        {
            int num1;
            char choice;
            do
            {
            Console.WriteLine("Enter a number");
            int.TryParse(Console.ReadLine(), out num1);

            if (num1 % 2 == 0)
            {
                Console.WriteLine("Even Number :" + num1);
            }
            else
            {
                Console.WriteLine("Odd Number :"+num1);
            }

             Console.WriteLine("Do you want to accept some more  EVEN or ODD number press 'Y',For Exit press any key");
            char.TryParse(Console.ReadLine(), out choice);
            }while(choice=='Y'|| choice=='y');

        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.even_odd();
            Console.ReadLine();


        }
    }
}
