using System;

public class RandomNumberStats{
    static void Main(){
        int[] numbers = Generate4DigitRandomArray(5);

        Console.WriteLine("Generated Numbers:");
        foreach (int num in numbers)
            Console.Write(num + " ");
        Console.WriteLine();

        double[] result = FindAverageMinMax(numbers);

        Console.WriteLine("Average: " + result[0]);
        Console.WriteLine("Minimum: " + result[1]);
        Console.WriteLine("Maximum: " + result[2]);
    }

    // Generate array of 4-digit random numbers
    static int[] Generate4DigitRandomArray(int size){
        int[] arr = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++){
            arr[i] = random.Next(1000, 10000); // 4-digit number
        }

        return arr;
    }

    // Find average, min, and max
    static double[] FindAverageMinMax(int[] numbers){
        int min = numbers[0];
        int max = numbers[0];
        int sum = 0;

        foreach (int num in numbers){
            sum += num;
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        double average = (double)sum / numbers.Length;

        return new double[] { average, min, max };
    }
}
