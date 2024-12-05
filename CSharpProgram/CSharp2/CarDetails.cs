using System;
class Car
{
//Member variables
string Engine;
int NoOfWheels;
//Member functions	
public void AcceptDetails()
{
    Console.WriteLine("Enter the Engine Model");
    Engine = Console.ReadLine();
    Console.WriteLine("Enter the number of Wheels");
    NoOfWheels = Convert.ToInt32(Console.ReadLine());
}
 public void DisplayDetails()
 {
     Console.WriteLine("The Engine Model is:{0}", Engine);
     Console.WriteLine("The number of wheels are:{0}", NoOfWheels);
 }
}
//Class used to instantiate the Car class
class CarDetails
{
    public static void Main(string[] args)
    {
        Car MyCar1 = new Car();
        Car MyCar2 = new Car();
        Console.WriteLine("First Car Details");
        Console.WriteLine("-----------------");
        MyCar1.AcceptDetails();
        MyCar1.DisplayDetails();
        Console.WriteLine("-----------------");
        Console.WriteLine("Second Car Details");
        Console.WriteLine("-----------------");
        MyCar2.AcceptDetails();
        MyCar2.DisplayDetails();
        Console.WriteLine("-----------------");
        Console.ReadLine();
    }
}
