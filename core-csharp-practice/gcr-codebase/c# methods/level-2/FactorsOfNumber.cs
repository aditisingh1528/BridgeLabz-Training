using System;

public class FactorsOfNumber{
    static void Main(){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.WriteLine("Factors:");
        foreach (int f in factors){
            Console.Write(f + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Sum of factors: " + SumOfFactors(factors));
        Console.WriteLine("Product of factors: " + ProductOfFactors(factors));
        Console.WriteLine("Sum of squares of factors: " + SumOfSquaresOfFactors(factors));
    }

    // Method to find factors and return array
    static int[] FindFactors(int number){
        int count = 0;

        // First loop: count factors
        for (int i = 1; i <= number; i++){
            if (number % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;

        // Second loop: store factors
        for (int i = 1; i <= number; i++){
            if (number % i == 0){
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    static int SumOfFactors(int[] factors){
        int sum = 0;
        foreach (int f in factors)
            sum += f;
        return sum;
    }

    static long ProductOfFactors(int[] factors){
        long product = 1;
        foreach (int f in factors)
            product *= f;
        return product;
    }

    static double SumOfSquaresOfFactors(int[] factors){
        double sum = 0;
        foreach (int f in factors)
            sum += Math.Pow(f, 2);
        return sum;
    }
}
