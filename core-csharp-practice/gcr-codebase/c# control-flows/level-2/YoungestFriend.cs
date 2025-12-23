using System;

class YoungestFriend{
    static void Main(){
		
        // Taking input of ages of Amar, Anthony and Anthony
        Console.WriteLine("Enter Amar's age:");
        int amarAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Akbar's age:");
        int akbarAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Anthony's age:");
        int anthonyAge = int.Parse(Console.ReadLine());

        // Taking input of weights of Amar, Anthony and Anthony
        Console.WriteLine("Enter Amar's height:");
        double amarHeight = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Akbar's height:");
        double akbarHeight = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Anthony's height:");
        double anthonyHeight = double.Parse(Console.ReadLine());

        // Finding the youngest among three
        if (amarAge <= akbarAge && amarAge <= anthonyAge)
            Console.WriteLine("Amar is the youngest");
        else if (akbarAge <= amarAge && akbarAge <= anthonyAge)
            Console.WriteLine("Akbar is the youngest");
        else
            Console.WriteLine("Anthony is the youngest");

        // Finding the tallest
        if (amarHeight >= akbarHeight && amarHeight >= anthonyHeight)
            Console.WriteLine("Amar is the tallest");
        else if (akbarHeight >= amarHeight && akbarHeight >= anthonyHeight)
            Console.WriteLine("Akbar is the tallest");
        else
            Console.WriteLine("Anthony is the tallest");
    }
}
