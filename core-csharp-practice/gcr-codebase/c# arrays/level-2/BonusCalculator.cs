using System;

public class BonusCalculator{
    static void Main(){
        const int EMP_COUNT = 10;

        // Creating Arrays to store data
        double[] salary = new double[EMP_COUNT];
        double[] yearsOfService = new double[EMP_COUNT];
        double[] bonus = new double[EMP_COUNT];
        double[] newSalary = new double[EMP_COUNT];

        // Variables for totals
        double totalBonus = 0.0;
        double totalOldSalary = 0.0;
        double totalNewSalary = 0.0;

        // Input loop
        for (int i = 0; i < EMP_COUNT; i++){
            Console.WriteLine($"\nEnter details for Employee {i + 1}");

            Console.Write("Enter the Salary: ");
            double sal = double.Parse(Console.ReadLine());

            Console.Write("Enter the Years of Service: ");
            double yrs = double.Parse(Console.ReadLine());

            // Validation
            if (sal <= 0 || yrs < 0){
                Console.WriteLine("Invalid input! Please enter again.");
                i--; // decrement index
                continue;
            }

            salary[i] = sal;
            yearsOfService[i] = yrs;
        }
		
        // Calculation loop
        for (int i = 0; i < EMP_COUNT; i++){
            if (yearsOfService[i] > 5){
                bonus[i] = salary[i] * 0.05; // 5% bonus
            }
            else{
                bonus[i] = salary[i] * 0.02; // 2% bonus
            }

            newSalary[i] = salary[i] + bonus[i];

            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }

        // Output
        Console.WriteLine("\n----- Zara Bonus Summary -----");
        Console.WriteLine("Total Old Salary: " + totalOldSalary);
        Console.WriteLine("Total Bonus Paid: " + totalBonus);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
    }
}
