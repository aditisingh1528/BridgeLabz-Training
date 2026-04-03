using System;

public class StudentGrade{
    static void Main(string[] args){
        Console.Write("Enter the number of students: ");
        int n;
        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0){
            Console.WriteLine("Invalid number of students");
            return;
        }
		
        double[] percentage = new double[n];
        char[] grade = new char[n];
		
        for (int i = 0; i < n; i++){
            Console.WriteLine("\nStudent " + (i + 1));
			
            Console.Write("Physics marks: ");
            if (!double.TryParse(Console.ReadLine(), out double phy)) { i--; continue; }
			
            Console.Write("Chemistry marks: ");
            if (!double.TryParse(Console.ReadLine(), out double chem)) { i--; continue; }
			
            Console.Write("Maths marks: ");
            if (!double.TryParse(Console.ReadLine(), out double math)) { i--; continue; }
			
            if (phy < 0 || chem < 0 || math < 0){
                Console.WriteLine("Enter positive marks only");
                i--;
                continue;
            }
			
            percentage[i] = (phy + chem + math) / 3;
			
            if (percentage[i] >= 80) grade[i] = 'A';
            else if (percentage[i] >= 70) grade[i] = 'B';
            else if (percentage[i] >= 60) grade[i] = 'C';
            else if (percentage[i] >= 50) grade[i] = 'D';
            else if (percentage[i] >= 40) grade[i] = 'E';
            else grade[i] = 'R';
        }
		
        Console.WriteLine("\nResult:");
        for (int i = 0; i < n; i++){
            Console.WriteLine($"Student {i + 1} Percentage: {percentage[i]} Grade: {grade[i]}");
        }
    }
}
