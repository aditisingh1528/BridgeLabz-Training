using System;

public class TriangleArea
{
    public static void Main(string[] args)
    {
        //ask user for height and base of triangle
        Console.WriteLine("Enter height of triangle in centimeters");
        double Height=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter base of triangle in centimeters");
        double Base=Convert.ToDouble(Console.ReadLine());

        //calculate area in centimeters
        double AreaCm=0.5*Base*Height;

        //convert dimensions to inches
        double HeightInch=Height/2.54;
        double BaseInch=Base/2.54;

        //convert dimensions to feet
        double HeightFeet=HeightInch/12;
        double BaseFeet=BaseInch/12;

        //calculate area in inches and feet
        double AreaInch=0.5*BaseInch*HeightInch;
        double AreaFeet=0.5*BaseFeet*HeightFeet;

        Console.WriteLine("Your Area in cm is "+AreaCm+" while in feet is "+AreaFeet+" and inches is "+AreaInch);
    }
}
