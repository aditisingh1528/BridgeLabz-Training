using System;
using System.Collections.Generic;

public class StudentScores{
    static void Main(){
        Console.Write("Enter number of students: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0){
            Console.WriteLine("Invalid number of students.");
            return;
        }

        List<double> scores = new List<double>();

        for (int i = 0; i < n; i++){
            Console.Write($"Enter score of student {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out double score) || score < 0){
                Console.WriteLine("Invalid score. Try again.");
                i--;
                continue;
            }
            scores.Add(score);
        }

        double avg = scores.Average();
        double max = scores.Max();
        double min = scores.Min();

        Console.WriteLine($"\nAverage Score: {avg}");
        Console.WriteLine($"Highest Score: {max}");
        Console.WriteLine($"Lowest Score: {min}");

        Console.WriteLine("Scores above average:");
        foreach (var s in scores.Where(s => s > avg))
            Console.WriteLine(s);
    }
}
