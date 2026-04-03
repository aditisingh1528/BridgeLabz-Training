using System;

public class StudentGrade2D{
    static void Main(string[] args){
        // Taking user input for marks
        Console.Write("Enter the number of students: ");
        int n = int.Parse(Console.ReadLine());
		
        // 2D array to store marks
        double[,] marks = new double[n, 3];
		
        // Array to store percentage of each student
        double[] percentage = new double[n];
		
        // Array to store grade of each student
        char[] grade = new char[n];
		
        // Loop to take marks input for each student
        for (int i = 0; i < n; i++){
            Console.WriteLine("\nStudent " + (i + 1));
			
            // Input Physics marks
            Console.Write("Physics marks: ");
            marks[i, 0] = double.Parse(Console.ReadLine());
			
            // Input Chemistry marks
            Console.Write("Chemistry marks: ");
            marks[i, 1] = double.Parse(Console.ReadLine());
			
            // Input Maths marks
            Console.Write("Maths marks: ");
            marks[i, 2] = double.Parse(Console.ReadLine());
			
            // Checking for negative marks
            if (marks[i, 0] < 0 || marks[i, 1] < 0 || marks[i, 2] < 0){
                Console.WriteLine("Invalid marks. Please enter positive values.");
                i--; // Repeat input for the same student
                continue;
            }
			
            // Calculating total marks of the student
            double total = marks[i, 0] + marks[i, 1] + marks[i, 2];
			
            // Calculating percentage
            percentage[i] = total / 3;
			
            // Assigning grade based on percentage
            if (percentage[i] >= 80) grade[i] = 'A';
            else if (percentage[i] >= 70) grade[i] = 'B';
            else if (percentage[i] >= 60) grade[i] = 'C';
            else if (percentage[i] >= 50) grade[i] = 'D';
            else if (percentage[i] >= 40) grade[i] = 'E';
            else grade[i] = 'R';
        }
		
        // Displaying final results
        Console.WriteLine("\nResult:");
        for (int i = 0; i < n; i++){
            Console.WriteLine("Student " + (i + 1) +
                              " Percentage: " + percentage[i] +
                              " Grade: " + grade[i]);
        }
    }
}
