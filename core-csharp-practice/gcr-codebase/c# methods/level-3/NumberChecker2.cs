using System;

public class NumberChecker2
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int digitCount = CountDigits(number);
        int[] digits = StoreDigits(number, digitCount);

        Console.WriteLine("Digit Count: " + digitCount);
        Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));
        Console.WriteLine("Is Armstrong Number: " + IsArmstrongNumber(number, digits));

        FindLargestAndSecondLargest(digits);
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

    // b. Store digits in array
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

    // c. Check Duck Number
    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int d in digits)
        {
            if (d != 0)
                return true;
        }
        return false;
    }

    // d. Check Armstrong Number
    public static bool IsArmstrongNumber(int number, int[] digits)
    {
        int sum = 0;
        int power = digits.Length;

        foreach (int d in digits)
        {
            sum += (int)Math.Pow(d, power);
        }
        return sum == number;
    }

    // e. Find largest and second largest digit
    public static void FindLargestAndSecondLargest(int[] digits)
    {
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        foreach (int d in digits)
        {
            if (d > largest)
            {
                secondLargest = largest;
                largest = d;
            }
            else if (d > secondLargest && d != largest)
            {
                secondLargest = d;
            }
        }

        Console.WriteLine("Largest Digit: " + largest);
        Console.WriteLine("Second Largest Digit: " + secondLargest);
    }
}
