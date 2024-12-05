using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp060716_E2
{
    class Program
    {
        static void Main(string[] args)
        {
            string orgstr = "C# makes strings easy";

            string substr = orgstr.Substring(5, 12);

            Console.WriteLine("orgstr : " + orgstr);
            Console.WriteLine("substr : " + substr);

            Console.ReadLine();
        }
    }
}
