using System;

public class StudentVoteChecker{
    // Method to check voting eligibility
    public static bool CanStudentVote(int age){
        // Validate age
        if (age < 0)
            return false;

        // Check voting condition
        if (age >= 18)
            return true;

        return false;
    }

    static void Main(){
        int[] ages = new int[10];

        for (int i = 0; i < ages.Length; i++){
            Console.Write("Enter age of student " + (i + 1) + ": ");
            ages[i] = int.Parse(Console.ReadLine());

            if (CanStudentVote(ages[i]))
                Console.WriteLine("Student " + (i + 1) + " can vote.");
            else
                Console.WriteLine("Student " + (i + 1) + " cannot vote.");
        }
    }
}
