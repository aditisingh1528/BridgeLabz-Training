using System;

public class ZaraBonus{
    const int EMPLOYEES = 10;
	
    static void Main(){
        // Step 1: Get old salary and years of service
        int[,] employeeData = GenerateSalaryAndService();
		
        // Step 2: Calculate new salary and bonus
        double[,] salaryResult = CalculateBonusAndNewSalary(employeeData);
		
        // Step 3: Display table and totals
        DisplaySummary(employeeData, salaryResult);
    }
	
    // Method to generate 5-digit salary and years of service
    static int[,] GenerateSalaryAndService(){
        Random random = new Random();
        int[,] data = new int[EMPLOYEES, 2];
		
        for (int i = 0; i < EMPLOYEES; i++){
            data[i, 0] = random.Next(10000, 100000); // 5-digit salary
            data[i, 1] = random.Next(1, 11);         // Years of service (1–10)
        }
		
        return data;
    }
	
    // Method to calculate bonus and new salary
    static double[,] CalculateBonusAndNewSalary(int[,] data){
        double[,] result = new double[EMPLOYEES, 2];
		
        for (int i = 0; i < EMPLOYEES; i++){
            int oldSalary = data[i, 0];
            int years = data[i, 1];
			
            double bonusRate = (years > 5) ? 0.05 : 0.02;
            double bonus = oldSalary * bonusRate;
            double newSalary = oldSalary + bonus;
			
            result[i, 0] = bonus;
            result[i, 1] = newSalary;
        }
		
        return result;
    }
	
    // Method to display table and total calculations
    static void DisplaySummary(int[,] data, double[,] result){
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;
		
        Console.WriteLine("Emp\tOld Salary\tYears\tBonus\t\tNew Salary");
        Console.WriteLine("-------------------------------------------------------------");
		
        for (int i = 0; i < EMPLOYEES; i++){
            int oldSalary = data[i, 0];
            int years = data[i, 1];
            double bonus = result[i, 0];
            double newSalary = result[i, 1];

            totalOldSalary += oldSalary;
            totalBonus += bonus;
            totalNewSalary += newSalary;

            Console.WriteLine($"{i + 1}\t{oldSalary}\t\t{years}\t{bonus:F2}\t{newSalary:F2}");
        }
		
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine($"TOTAL\t{totalOldSalary:F2}\t\t\t{totalBonus:F2}\t{totalNewSalary:F2}");
    }
}
