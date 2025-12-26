using System;

public class SimpleCalendar{
    static void Main(){
        Console.Write("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        PrintCalendar(month, year);
    }
	
    // Prints calendar for given month and year
    static void PrintCalendar(int month, int year){
        int days = DateTime.DaysInMonth(year, month);
        DateTime firstDay = new DateTime(year, month, 1);
		
        Console.WriteLine("\nSun Mon Tue Wed Thu Fri Sat");
		
        // Print spaces before first day
        for (int i = 0; i < (int)firstDay.DayOfWeek; i++){
            Console.Write("    ");
        }
		
        // Print all days
        for (int day = 1; day <= days; day++){
            Console.Write($"{day,3} ");
			
            if ((day + (int)firstDay.DayOfWeek) % 7 == 0)
                Console.WriteLine();
        }
    }
}
