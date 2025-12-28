using System;

public class PrimeChecker{
    static void Main(){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
            Console.WriteLine("Prime Number");
        else
            Console.WriteLine("Not a Prime Number");
    }

    static bool IsPrime(int num){
        if (num <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(num); i++){
            if (num % i == 0)
                return false;
        }
        return true;
    }
}
