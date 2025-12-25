using System;

public class NumberChecker6
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.Write("Factors: ");
        PrintArray(factors);

        Console.WriteLine("Greatest Factor: " + FindGreatestFactor(factors));
        Console.WriteLine("Sum of Factors: " + SumOfFactors(factors));
        Console.WriteLine("Product of Factors: " + ProductOfFactors(factors));
        Console.WriteLine("Product of Cube of Factors: " + ProductOfCubeOfFactors(factors));

        Console.WriteLine("Is Perfect Number: " + IsPerfect(number));
        Console.WriteLine("Is Abundant Number: " + IsAbundant(number));
        Console.WriteLine("Is Deficient Number: " + IsDeficient(number));
        Console.WriteLine("Is Strong Number: " + IsStrong(number));
    }

    // a. Find factors and return as array
    public static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                factors[index++] = i;
        }
        return factors;
    }

    // b. Greatest factor
    public static int FindGreatestFactor(int[] factors)
    {
        int max = factors[0];
        foreach (int f in factors)
        {
            if (f > max)
                max = f;
        }
        return max;
    }

    // c. Sum of factors
    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int f in factors)
            sum += f;
        return sum;
    }

    // d. Product of factors
    public static long ProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int f in factors)
            product *= f;
        return product;
    }

    // e. Product of cube of factors
    public static double ProductOfCubeOfFactors(int[] factors)
    {
        double product = 1;
        foreach (int f in factors)
            product *= Math.Pow(f, 3);
        return product;
    }

    // f. Perfect number check
    public static bool IsPerfect(int number)
    {
        int sum = 0;
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
                sum += i;
        }
        return sum == number;
    }

    // g. Abundant number check
    public static bool IsAbundant(int number)
    {
        int sum = 0;
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
                sum += i;
        }
        return sum > number;
    }

    // h. Deficient number check
    public static bool IsDeficient(int number)
    {
        int sum = 0;
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
                sum += i;
        }
        return sum < number;
    }

    // i. Strong number check
    public static bool IsStrong(int number)
    {
        int sum = 0;
        int temp = number;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }
        return sum == number;
    }

    // Factorial helper method
    public static int Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
            fact *= i;
        return fact;
    }

    // Utility method to print array
    public static void PrintArray(int[] arr)
    {
        foreach (int x in arr)
            Console.Write(x + " ");
        Console.WriteLine();
    }
}
