using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace CSharp050716_E3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "When it comes to .Net programming, C# is #1";
            string str2 = "When it comes to .Net programming, C# is #1";
            string str3 = "C# strings are powerful.";

            string strUp, strLow;
            int result, idx;

            Console.WriteLine("str1: " + str1);

            Console.WriteLine("Length of str1: " + str1.Length);

            strLow = str1.ToLower(CultureInfo.CurrentCulture);

            strUp = str1.ToUpper(CultureInfo.CurrentCulture);

            Console.WriteLine("Lowercase version for str1:\n " + strLow);
            Console.WriteLine("Uppercase version for str1:\n " + strUp);

            Console.WriteLine();

            Console.WriteLine("Display str1, one char at atime.");
            for(int i=0;i<str1.Length;i++)
                Console.WriteLine(str1[i]);
            Console.WriteLine("\n");

            if(str1==str2)
                Console.WriteLine("str1 == str2");
            else
                Console.WriteLine("str1 != str2");

             if(str1==str3)
                Console.WriteLine("str1 == str3");
            else
                Console.WriteLine("str1 != str3");

            result = string.Compare(str1,str3,StringComparison.CurrentCulture);

            if(result==0)
                Console.WriteLine("str1 and str3 are equal");
            else if(result < 0)
                Console.WriteLine("str1 is less than str3");
            else
                Console.WriteLine("str1 is greater than str3");

            Console.WriteLine();

            str2 = "One Two Three One";

            idx=str2.IndexOf("One",StringComparison.Ordinal);
            Console.WriteLine("Index of first occurance of one:"+idx);
                
            idx=str2.LastIndexOf("One",StringComparison.Ordinal);
            Console.WriteLine("Index of lastt occurance of one:"+idx);

            Console.ReadLine();
        }
    }
}
