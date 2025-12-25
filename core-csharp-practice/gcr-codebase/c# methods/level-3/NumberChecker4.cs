using System;

public class NumberChecker4
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int count = CountDigits(number);
        int[] digits = StoreDigits(number, count);
        int[] reversedDigits = ReverseArray(digits);

        Console.WriteLine("Digit Count: " + count);

        Console.Write("Digits: ");
        PrintArray(digits);

        Console.Write("Reversed Digits: ");
        PrintArray(reversedDigits);

        Console.WriteLine("Arrays Equal: " + AreArraysEqual(digits, reversedDigits));
        Console.WriteLine("Is Palindrome Number: " + IsPalindrome(digits, reversedDigits));
        Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));
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

    // b. Reverse digits array
    public static int[] ReverseArray(int[] digits)
    {
        int[] reversed = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            reversed[i] = digits[digits.Length - 1 - i];
        }
        return reversed;
    }

    // c. Compare two arrays
    public static bool AreArraysEqual(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
            return false;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
                return false;
        }
        return true;
    }

    // d. Check Palindrome
    public static bool IsPalindrome(int[] digits, int[] reversedDigits)
    {
        return AreArraysEqual(digits, reversedDigits);
    }

    // e. Check Duck Number
    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int d in digits)
        {
            if (d != 0)
                return true;
        }
        return false;
    }

    // Utility method to print array
    public static void PrintArray(int[] arr)
    {
        foreach (int x in arr)
            Console.Write(x + " ");
        Console.WriteLine();
    }
}
