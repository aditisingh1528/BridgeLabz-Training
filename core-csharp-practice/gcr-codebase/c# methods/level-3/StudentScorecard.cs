using System;

public class StudentScorecard{
    static void Main(){
        Console.Write("Enter number of students: ");
        int students = int.Parse(Console.ReadLine());
		
        int[,] pcmMarks = GeneratePCMScores(students);
        double[,] results = CalculateResults(pcmMarks, students);
		
        DisplayScorecard(pcmMarks, results, students);
    }

    // Generate random 2-digit PCM marks for students
    static int[,] GeneratePCMScores(int students){
        Random random = new Random();
        int[,] marks = new int[students, 3];
		
        for (int i = 0; i < students; i++){
            marks[i, 0] = random.Next(10, 100); // Physics
            marks[i, 1] = random.Next(10, 100); // Chemistry
            marks[i, 2] = random.Next(10, 100); // Maths
        }
        return marks;
    }
	
    // Calculate total, average, and percentage
    static double[,] CalculateResults(int[,] marks, int students){
        double[,] result = new double[students, 3];
		
        for (int i = 0; i < students; i++){
            int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
            double average = Math.Round(total / 3.0, 2);
            double percentage = Math.Round((total / 300.0) * 100, 2);
			
            result[i, 0] = total;
            result[i, 1] = average;
            result[i, 2] = percentage;
        }
        return result;
    }
	
    // Display scorecard in tabular format
    static void DisplayScorecard(int[,] marks, double[,] result, int students){
        Console.WriteLine("\nID\tPhy\tChem\tMath\tTotal\tAvg\t%");
        for (int i = 0; i < students; i++){
            Console.WriteLine(
                (i + 1) + "\t" +
                marks[i, 0] + "\t" +
                marks[i, 1] + "\t" +
                marks[i, 2] + "\t" +
                result[i, 0] + "\t" +
                result[i, 1] + "\t" +
                result[i, 2]
            );
        }
    }
}
