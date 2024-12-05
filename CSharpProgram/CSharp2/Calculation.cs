using System;

class Caluculation
{
	static void Main(string[] args)
        {
		int num1,num2,num3;
		Console.WriteLine("Enter Number1 :");
            	num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Number2 :");
            	num2 = Convert.ToInt32(Console.ReadLine());
		num3=num1+num2;
		Console.WriteLine("Total is {0}",num3);
		Console.ReadLine();
	}
}
			
