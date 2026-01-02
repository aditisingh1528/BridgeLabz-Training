using System;

public class Circle
{
    private double radius;

    // Default constructor
    public Circle() : this(1.0) { }

    // Parameterized constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    static void Main()
    {
        Circle c1 = new Circle();
        Circle c2 = new Circle(5);

        Console.WriteLine(c1.GetArea());
        Console.WriteLine(c2.GetArea());
    }
}