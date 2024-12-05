using System;
class Car
{
    //Member variables
    string Engine;
    int NoOfWheels;
    //Member functions
    public void AcceptDetails()
    {
        Console.WriteLine("enter the engine model");
        Engine=Console.ReadLine();
        Console.WriteLine("Enter the number of wheels");
        NoOfWheels=Convert.ToInt32(Console.ReadLine());
    }
    public void DisplayDetails()
    {
        Console.WriteLine("the engine model is:{0}", Engine);
        Console.WriteLine("the number of wheels are:{0}", NoOfWheels);
    }
    }
//class used to istantiate the car class

class CarDetails
{
    public static void Main(String[] args)
    {

    Car MyCar1=new Car();
    Car MyCar2=new Car();
    Console.WriteLine("First car details");
    Console.WriteLine("-----------------");
    MyCar1.AcceptDetails();
    MyCar1.DisplayDetails();
    Console.WriteLine("-----------------");
    Console.WriteLine("second car details");
    Console.WriteLine("-----------------");
    MyCar2.AcceptDetails();
    MyCar2.DisplayDetails();
Console.WriteLine("...............");
        Console.ReadLine();
    }
}
