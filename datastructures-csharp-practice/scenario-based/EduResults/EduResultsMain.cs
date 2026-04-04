using System;

public class EduResultsMain
{
    public static void Main(string[] Args)
    {
        Console.Write("Enter number of districts: ");
        int DistrictCount = Convert.ToInt32(Console.ReadLine());

        District[] Districts = new District[DistrictCount];
        int TotalStudents = 0;

        for (int I = 0; I < DistrictCount; I++)
        {
            Console.Write("Enter district name: ");
            string DistrictName = Console.ReadLine();

            Console.Write("Enter number of students in " + DistrictName + ": ");
            int StudentCount = Convert.ToInt32(Console.ReadLine());

            Student[] Students = new Student[StudentCount];

            Console.WriteLine("Enter sorted marks for " + DistrictName + ":");
            for (int J = 0; J < StudentCount; J++)
            {
                int Marks = Convert.ToInt32(Console.ReadLine());
                Students[J] = new Student(Marks, DistrictName);
            }

            Districts[I] = new District(DistrictName, Students);
            TotalStudents += StudentCount;
        }

        // Combine all students into one array
        Student[] AllStudents = new Student[TotalStudents];
        int Index = 0;

        for (int I = 0; I < DistrictCount; I++)
        {
            Student[] DistrictStudents = Districts[I].GetStudents();
            for (int J = 0; J < DistrictStudents.Length; J++)
            {
                AllStudents[Index++] = DistrictStudents[J];
            }
        }

        // Sort at state level
        StateRankMerger Merger = new StateRankMerger();
        Merger.MergeSort(AllStudents, 0, AllStudents.Length - 1);

        Console.WriteLine("\nFinal State-wise Rank List:");
        for (int I = 0; I < AllStudents.Length; I++)
        {
            Console.WriteLine(
                "Marks: " + AllStudents[I].GetMarks() +
                " | District: " + AllStudents[I].GetDistrictName()
            );
        }
    }
}