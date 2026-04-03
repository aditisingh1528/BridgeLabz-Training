using System;

public class EricTravels
{
    public static void Main(string[] args)
    {
        //take travel details as user input
        Console.WriteLine("Enter name: ");
        string Name=Console.ReadLine();
        Console.WriteLine("Enter from city: ");
        string FromCity=Console.ReadLine();
        Console.WriteLine("Enter via city: ");
        string ViaCity=Console.ReadLine();
        Console.WriteLine("Enter destination city: ");
        string ToCity=Console.ReadLine();
		
        Console.WriteLine("Enter distance from to via in miles: ");
        double Distance1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter distance via to destination in miles:");
        double Distance2=Convert.ToDouble(Console.ReadLine());

        //calculate total distance
        double TotalDistance=Distance1+Distance2;

        Console.WriteLine("The total distance travelled by "+Name+" from "+FromCity+" to "+ToCity+" via "+ViaCity+" is "+TotalDistance+" miles");
    }
}
