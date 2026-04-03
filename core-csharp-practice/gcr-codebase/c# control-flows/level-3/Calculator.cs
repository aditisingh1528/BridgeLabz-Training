using System;

class Calculator{
    static void Main(){
		
		//taking the inputs
        Console.WriteLine("Enter first number: ");
        double first = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        double second = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter operator (+, -, *, /): ");
        string operators = Console.ReadLine();
		
        switch (operators){
            case "+":
                Console.WriteLine("Result: " + (first + second));
                break;

            case "-":
                Console.WriteLine("Result: " + (first - second));
                break;

            case "*":
                Console.WriteLine("Result: " + (first * second));
                break;

            case "/":
                if (second != 0)
                    Console.WriteLine("Result: " + (first / second));
                else
                    Console.WriteLine("Cannot divide by zero");
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
