using System;

class BodyMassIndex{
	
    static void Main(){
		
		//taking inpt of weight and height to calculate BMI
        Console.Write("Enter weight (kg): ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter height (cm): ");
        double heightCm = double.Parse(Console.ReadLine());

        double heightM = heightCm / 100;
		
		//formula to calculate BMI
        double bmi = weight / (heightM * heightM);
		
		//printing the calculated BMI
        Console.WriteLine("BMI = " + bmi);
		
		//printing the status of the person based on the calculated BMI
        if (bmi <= 18.4)
            Console.WriteLine("Status: Underweight");
        else if (bmi <= 24.9)
            Console.WriteLine("Status: Normal");
        else if (bmi <= 39.9)
            Console.WriteLine("Status: Overweight");
        else
            Console.WriteLine("Status: Obese");
    }
}