using System;

class StoreAndSum{
    static void Main(){
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        // Taking input using infinite loop
        while (true){
            Console.Write("Enter a number: ");
            double input = double.Parse(Console.ReadLine());

            if (input <= 0 || index == 10)
                break;

            numbers[index] = input;
            index++;
        }

        // Display numbers and calculate sum
        Console.WriteLine("Entered numbers: ");
        for (int i = 0; i < index; i++){
            Console.WriteLine(numbers[i]);
            total += numbers[i];
        }

        Console.WriteLine("Sum of all numbers = " + total);
    }
}
