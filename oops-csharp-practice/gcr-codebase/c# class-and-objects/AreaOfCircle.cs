using System;

// Circle class to perform circle calculations
public class Circle{

    public double Radius;

    //Method to calculate area
    public double CalculateArea(){
        return Math.PI * Radius * Radius;
    }

    //Method to calculate circumference
    public double CalculateCircumference(){
        return 2 * Math.PI * Radius;
    }
}

class Program{
    static void Main(){

        //Creating Circle object
        Circle c = new Circle();

        //Setting radius
        c.Radius = 7;

        //Displaying results
        Console.WriteLine("Area of Circle: " + c.CalculateArea());
        Console.WriteLine("Circumference of Circle: " + c.CalculateCircumference());
    }
}
