using System;
using System.Collections.Generic;
using System.Text;


    class Duplicate
    {
        static void Main(string[] args)
        {
            char[] ch=new char[10];
            int i, j, count=0, flag = 0;
            char temp = ' ';
            Console.WriteLine("Enter a string of ten characters:");
            for (i = 0; i <= 9; i++)
            {
                ch[i] =Convert.ToChar(Console.ReadLine());
            }
            for (i = 0; i <=9;i++)
            {
                if (ch[i] != temp)
                {
                    count = 1;
                 for (j = i + 1; j < 10;j++)
                 {
                    if (ch[i] == ch[j])
                    {
	                    count = count + 1;
   	                    temp = ch[i];
                        flag = 1;
                    }
                 }
                }
            if (flag == 1 && ch[i] == temp)
            {
				Console.WriteLine("Total no. of ' + temp + 'in the string = " + count);
            }
		}
  	 }
      
    }


 
