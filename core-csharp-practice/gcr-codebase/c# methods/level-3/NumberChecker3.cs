using System;

public class NumberChecker3
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int digitCount = CountDigits(number);
        int[] digits = StoreDigits(number, digitCount);

        Console.WriteLine("Digit Count: " + digitCount);
        Console.WriteLine("Sum of Digits: " + SumOfDigits(digits));
        Console.WriteLine("Sum of Squares of Digits: " + SumOfSquaresOfDigits(digits));
        Console.WriteLine("Is Harshad Number: " + IsHarshadNumber(number, digits));

        int[,] frequency = DigitFrequency(digits);
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
                Console.WriteLine("Digit " + frequency[i, 0] + " -> " + frequency[i, 1]);
        }
    }

    // a. Count digits
    public static int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    // a. Store digits in array
    public static int[] StoreDigits(int number, int size)
    {
        int[] digits = new int[size];
        for (int i = size - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // b. Sum of digits
    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int d in digits)
            sum += d;
        return sum;
    }

    // c. Sum of squares of digits
    public static int SumOfSquaresOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int d in digits)
            sum += (int)Math.Pow(d, 2);
        return sum;
    }

    // d. Check Harshad number
    public static bool IsHarshadNumber(int number, int[] digits)
    {
        int sum = SumOfDigits(digits);
        return number % sum == 0;
    }

    // e. Frequency of each digit (2D array)
    public static int[,] DigitFrequency(int[] digits)
    {
        int[,] freq = new int[10, 2];

        for (int i = 0; i < 10; i++)
            freq[i, 0] = i;

        foreach (int d in digits)
            freq[d, 1]++;

        return freq;
    }
}
