using System;

public class SpringSeason2{
    static void Main(string[] args){
        // Check if month and day are provided
        if (args.Length < 2){
            Console.WriteLine("Please provide month and day as command-line arguments.");
            return;
        }

        int month = int.Parse(args[0]);
        int day = int.Parse(args[1]);

        if (IsSpringSeason(month, day))
            Console.WriteLine("Its a Spring Season");
        else
            Console.WriteLine("Not a Spring Season");
    }

    // Method to check Spring Season
    static bool IsSpringSeason(int month, int day){
        return (month == 3 && day >= 20) ||
               (month == 4) ||
               (month == 5) ||
               (month == 6 && day <= 20);
    }
}
