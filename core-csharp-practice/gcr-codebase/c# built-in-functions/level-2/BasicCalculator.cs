using System;

public class BasicCalculator{
    static void Main(){
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Choose operation (+ - * /): ");
        char op = Console.ReadLine()[0];

        double result = 0;

        switch (op){
            case '+': result = Add(a, b); break;
            case '-': result = Subtract(a, b); break;
            case '*': result = Multiply(a, b); break;
            case '/': result = Divide(a, b); break;
        }

        Console.WriteLine("Result: " + result);
    }

    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b) => a / b;
}
