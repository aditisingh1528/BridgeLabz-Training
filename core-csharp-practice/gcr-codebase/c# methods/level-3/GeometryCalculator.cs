using System;

public class GeometryCalculator
{
    static void Main()
    {
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        double distance = FindEuclideanDistance(x1, y1, x2, y2);
        double[] lineEquation = FindLineEquation(x1, y1, x2, y2);

        Console.WriteLine("\nEuclidean Distance: " + distance);
        Console.WriteLine("Line Equation: y = " + lineEquation[0] + "x + " + lineEquation[1]);
    }

    // b. Method to find Euclidean distance
    public static double FindEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(
            Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)
        );
    }

    // d. Method to find slope and y-intercept
    public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        double m = (y2 - y1) / (x2 - x1);
        double b = y1 - (m * x1);

        return new double[] { m, b };
    }
}
