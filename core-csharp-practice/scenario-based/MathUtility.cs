using System;

public class MathUtility{
    static void Main(string[] args){
        Console.WriteLine("Enter a number for factorial: ");
        int number1 = int.Parse(Console.ReadLine());

        if (number1 < 0)
            Console.WriteLine("Please enter a positive number");
        else
            Console.WriteLine("The factorial is: " + Factorial(number1));

        Console.WriteLine("Enter a number to check if it is prime: ");
        int number2 = int.Parse(Console.ReadLine());

        if (IsPrime(number2))
            Console.WriteLine("It is a Prime Number");
        else
            Console.WriteLine("It is not a Prime Number");

        Console.WriteLine("Enter the first number for GCD: ");
        int number3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number for GCD: ");
        int number4 = int.Parse(Console.ReadLine());

        Console.WriteLine("The GCD of the two numbers is: " + GCD(number3, number4));

        Console.WriteLine("Enter a number for fibonacci: ");
        int number5 = int.Parse(Console.ReadLine());

        if (number5 < 0)
            Console.WriteLine("Please enter a positive number");
        else
            Console.WriteLine("Fibonacci: " + Fibonacci(number5));
    }

    public static long Factorial(int n){
        long ans = 1;
        for (int i = 1; i <= n; i++)
            ans *= i;
        return ans;
    }

    public static bool IsPrime(int n){
        if (n <= 1) return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }

    public static int GCD(int a, int b){
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static int Fibonacci(int n){
        if (n == 0) return 0;
        if (n == 1) return 1;

        int a = 0, b = 1;
        for (int i = 2; i <= n; i++){
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
}
