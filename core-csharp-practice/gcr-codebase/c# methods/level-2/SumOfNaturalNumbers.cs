using System;

public class SumOfNaturalNumbers{
    static void Main(){
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        // Check for natural number
        if (n <= 0){
            Console.WriteLine("Not a natural number. Exiting program.");
            return;
        }

        int recursiveSum = SumByRecursion(n);
        int formulaSum = SumByFormula(n);

        Console.WriteLine("Sum using recursion: " + recursiveSum);
        Console.WriteLine("Sum using formula: " + formulaSum);

        if (recursiveSum == formulaSum)
            Console.WriteLine("Both results are correct and equal.");
        else
            Console.WriteLine("Results do not match.");
    }

    // Recursive method
    static int SumByRecursion(int n){
        if (n == 1)
            return 1;
        return n + SumByRecursion(n - 1);
    }

    // Formula method
    static int SumByFormula(int n){
        return n * (n + 1) / 2;
    }
}
