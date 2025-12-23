using System;

public class SumUntilZero{
	static void Main(){
		double total = 0.0;
        double number; //input value entered by user

        number = Convert.ToDouble(Console.ReadLine());

        while (number != 0)
        {
            total += number;
            number = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine(total);
	}
}