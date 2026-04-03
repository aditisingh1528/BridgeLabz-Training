using System;

public class IntOperation
{
    public static void Main(string[] args)
    {
        //take input values for operands
        Console.WriteLine("Enter value of a: ");
        int A=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value of b: ");
        int B=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value of c: ");
        int C=Convert.ToInt32(Console.ReadLine());

        //perform integer operations
        int Result1=A+B*C;
        int Result2=A*B+C;
        int Result3=C+A/B;
        int Result4=A%B+C;

        Console.WriteLine("The results of Int Operations are "+Result1+", "+Result2+", "+Result3+" and "+Result4);
    }
}
