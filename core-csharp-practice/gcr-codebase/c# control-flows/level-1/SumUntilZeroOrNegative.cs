using System;

class SumUntilZeroOrNegative{
    static void Main(){
		
        double total = 0.0;

        while (true){
            double number = Convert.ToDouble(Console.ReadLine());

            if (number <= 0)
                break;

            total += number;
        }

        Console.WriteLine(total);
    }
}
