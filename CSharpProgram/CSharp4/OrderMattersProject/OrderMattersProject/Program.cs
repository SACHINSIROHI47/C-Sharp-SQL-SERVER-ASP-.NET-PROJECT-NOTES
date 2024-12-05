using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMattersProject
{
    class ExceptionA : Exception
    {
        public ExceptionA(string message) : base(message)
        {

        }

        public override string ToString()
        {
            return Message;
        }
    }

    class ExceptionB : ExceptionA
    {
        public ExceptionB(string message) : base(message)
        {
            
        }

        public override string ToString()
        {
            return Message;
        }
    }
    class OrderMatters
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 3; x++)
            {
                try
                {
                    if (x == 0)
                        throw new ExceptionA("Caught and ExceptionA Exception");
                    else if(x == 1)
                         throw new ExceptionB("Caught and ExceptionB Exception");
                    else
                        throw new Exception();
                }
                catch(ExceptionB exc)
                {
                    Console.WriteLine(exc);
                }
                catch(ExceptionA exc)
                {
                    Console.WriteLine(exc);
                }
                 catch(Exception exc)
                {
                    Console.WriteLine(exc);
                }

                }
            Console.ReadLine();
             }
        
        }

    }

