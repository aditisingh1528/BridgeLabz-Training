using System;

public class Quadratic{
    static void Main(){
        Console.Write("Enter value of a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter value of b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter value of c: ");
        double c = double.Parse(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 0){
            Console.WriteLine("No real roots (delta is negative).");
        }
        else if (roots.Length == 1){
            Console.WriteLine("One root: " + roots[0]);
        }
        else{
            Console.WriteLine("Root 1: " + roots[0]);
            Console.WriteLine("Root 2: " + roots[1]);
        }
    }

    // Method to find roots of quadratic equation
    static double[] FindRoots(double a, double b, double c){
        // delta = b^2 - 4ac
        double delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta > 0){
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0){
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else{
            // No real roots
            return new double[0];
        }
    }
}
