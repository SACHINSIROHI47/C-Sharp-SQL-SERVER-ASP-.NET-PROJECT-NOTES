using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {

        public void swtwithstr()
        {
            char vow;
            char ch1;
            do
            {
            Console.WriteLine("Please Enter a vowles");
            char.TryParse(Console.ReadLine(), out vow);

            switch (vow)
            {
                case 'a':
                    Console.WriteLine("A is vowles");
                    break;
                case 'e':
                    Console.WriteLine("e is vowles");
                    break;
                case 'i':
                    Console.WriteLine("i is vowles");
                    break;
                case 'o':
                    Console.WriteLine("o is vowles");
                    break;
                case 'u':
                    Console.WriteLine("u is vowles");
                    break;
                default:
                    Console.WriteLine("This character is not vowles");
                    break;

            }

                Console.WriteLine("Enter Y for yes N for No");
                char.TryParse(Console.ReadLine(), out ch1);

            } while (ch1 == 'Y' || ch1 == 'y');
            

            

        }
        public void swtwithint()
        {
            int choice;
            char ch;
            
            do 
            {

                Console.WriteLine("Please enter a number for week days");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    case 6:
                        Console.WriteLine("Friday");
                        break;
                    case 7:
                        Console.WriteLine("saturday");
                        break;
                    default:
                        Console.WriteLine("No days is found");
                        break;


                }
                Console.WriteLine("Enter Y for yes N for No");
                char.TryParse(Console.ReadLine(), out ch);

            } while (ch == 'Y' || ch == 'y');
            
            

        }


        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.swtwithstr();
            obj.swtwithint();
            Console.ReadKey();
        }
    }
}
