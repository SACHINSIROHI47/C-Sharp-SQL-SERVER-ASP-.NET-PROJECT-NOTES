using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
namespace ConsoleApplication9
{
    class strng
    {
        public void sst()
        {
            char ch = 'b';
            int rest;
            char[] chary = { 'H', 'e', 'l', 'l' };

            String str2 = new String(chary);
            String str1 = "Hello word compt";
            String str3 = "Hello word compt";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str1.Length);
            Console.WriteLine(rest = String.Compare(str1, str3));
            Console.WriteLine(str1.ToUpper(CultureInfo.CurrentCulture));
            Console.WriteLine(str1.ToLower(CultureInfo.CurrentCulture));
            if (String.Compare(str1, str3) == 0)
            {
                Console.WriteLine("String are equal..1");
            }
            else
            {
                Console.WriteLine("String are not equal..1");
            }
            if (str1 != str3)
            {
                Console.WriteLine("String are equal..2");
            }
            else
            {
                Console.WriteLine("String are not equal..2");
            }
            if (str1.Equals(str3))
            {
                Console.WriteLine("String are equal..3");
            }
            else
            {
                Console.WriteLine("String are not equal..3");
            }


            String s1 = "Computer";
            String s2 = "Java";
            String s3 = "C++";
            String s4 = s1 +" "+ s2+" " + s3;
            Console.WriteLine(s4);

            String[] strary = { "c","c++","java","c#","visual basic"};
            for (int a = 0; a < strary.Length; a++)
            {
                Console.WriteLine(strary[a]);
            }
          
            foreach(String b in strary)
            {
                Console.WriteLine(b);
            }

            String[] sstr2=new String[5];
 
            sstr2[0]="keyboard";
            sstr2[1] = "Mouse";
            Console.WriteLine(sstr2[0]);
            Console.WriteLine(sstr2[1]);

            String sbstring = "Welcome to the RGPG college";
            String sb = sbstring.Substring(0, 25);
            Console.WriteLine(sb);
        }
    }
}
