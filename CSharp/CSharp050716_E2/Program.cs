using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp050716_E2
{
    class Program
    {
        static void Main(string[] args)
        {
            char []charray = {'A',' ','S','t','r','i','n','g','.'};
            string str1 = new string(charray);
            string str2 = "Anothor string";

            Console.WriteLine(str1);
            Console.WriteLine(str2);

            Console.ReadLine();

        }
    }
}
