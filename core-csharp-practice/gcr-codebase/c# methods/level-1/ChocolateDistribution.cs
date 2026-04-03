using System;

public class ChocolateDistribution{
    static void Main(){
        Console.Write("Enter number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());
		
        Console.Write("Enter number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());
		
        int[] result = DistributeChocolates(numberOfChocolates, numberOfChildren);
		
        Console.WriteLine("Each child gets: " + result[0] + " chocolates");
        Console.WriteLine("Remaining chocolates: " + result[1]);
    }
	
    // Method to calculate chocolates per child and remaining chocolates
    public static int[] DistributeChocolates(int chocolates, int children){
        int eachChildGets = chocolates / children;
        int remaining = chocolates % children;
		
        return new int[] { eachChildGets, remaining };
    }
}
