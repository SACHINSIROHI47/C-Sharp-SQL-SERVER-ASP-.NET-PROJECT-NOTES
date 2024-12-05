using System;
class TennisPlayer
{
    //Member variables
    string Name;
    int Rank;
    float Winning_average;
    //Member functions
    public void AcceptDetails()
    {
        Console.WriteLine("enter the name");
        Name = Console.ReadLine();
        Console.WriteLine("Enter the rank");
        Rank = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the winning average");
        Winning_average = (float)Convert.ToDecimal(Console.ReadLine());

    }
    public void DisplayDetails()
    {
        Console.WriteLine("the name is:{0}", Name);
        Console.WriteLine("the rank is:{0}", Rank);
        Console.WriteLine("the winning_average is:{0}", Winning_average);
    }
}
//class used to istantiate the Tennis_player class

class TennisPlayerDetails
{
    public static void Main(String[] args)
    {

        TennisPlayer MyTennisPlayer1 = new TennisPlayer();
        TennisPlayer MyTennisPlayer2 = new TennisPlayer();
        Console.WriteLine("First Tennis player details");
        Console.WriteLine("-----------------");
        MyTennisPlayer1.AcceptDetails();
        MyTennisPlayer1.DisplayDetails();
        Console.WriteLine("-----------------");
        Console.WriteLine("second Tennis player details");
        Console.WriteLine("-----------------");
        MyTennisPlayer2.AcceptDetails();
        MyTennisPlayer2.DisplayDetails();
        Console.WriteLine("-------------------");
        Console.ReadLine();
    }
}