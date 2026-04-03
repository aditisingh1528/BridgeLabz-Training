using System;

public class DoubleOpt
{
    public static void Main(string[] args)
    {
        //take double type input values for operands
        Console.WriteLine("Enter value of a: ");
        double A=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter value of b: ");
        double B=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter value of c: ");
        double C=Convert.ToDouble(Console.ReadLine());

        //perform double operations
        double Result1=A+B*C;
        double Result2=A*B+C;
        double Result3=C+A/B;
        double Result4=A%B+C;

        Console.WriteLine("The results of Double Operations are "+Result1+", "+Result2+", "+Result3+" and "+Result4);
    }
}
