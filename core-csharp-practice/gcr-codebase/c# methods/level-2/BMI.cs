using System;

class BMIProgram
{
    static void Main()
    {
        const int persons = 10;
        double[,] data = new double[persons, 3]; // weight, height, BMI
        string[] status = new string[persons];

        for (int i = 0; i < persons; i++)
        {
            Console.WriteLine($"\nEnter details for Person {i + 1}");

            Console.Write("Weight (kg): ");
            data[i, 0] = double.Parse(Console.ReadLine());

            Console.Write("Height (cm): ");
            data[i, 1] = double.Parse(Console.ReadLine());

            data[i, 2] = CalculateBMI(data[i, 0], data[i, 1]);
            status[i] = GetBMIStatus(data[i, 2]);
        }

        Console.WriteLine("\n--- BMI Report ---");
        for (int i = 0; i < persons; i++)
        {
            Console.WriteLine($"Person {i + 1}: Weight={data[i,0]} kg, Height={data[i,1]} cm, BMI={data[i,2]:F2}, Status={status[i]}");
        }
    }

    static double CalculateBMI(double weight, double heightCm)
    {
        double heightMeter = heightCm / 100;
        return weight / (heightMeter * heightMeter);
    }

    static string GetBMIStatus(double bmi)
    {
        if (bmi <= 18.4) return "Underweight";
        else if (bmi <= 24.9) return "Normal";
        else if (bmi <= 39.9) return "Overweight";
        else return "Obese";
    }
}