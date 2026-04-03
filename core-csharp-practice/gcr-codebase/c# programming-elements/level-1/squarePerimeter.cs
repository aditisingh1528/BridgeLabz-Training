using System;

public class squarePerimeter{
    static void Main(){
		
        double perimeter;

        // Input
        Console.Write("Enter the perimeter of the square: ");
        perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculate side
        double side = perimeter / 4;

        // Output
        Console.WriteLine("The length of the side is " + side + " whose perimeter is " + perimeter);
    }
}
