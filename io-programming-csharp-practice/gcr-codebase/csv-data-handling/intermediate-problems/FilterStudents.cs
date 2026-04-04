using System;
using System.IO;


class FilterStudents
{
    static void Main(string[] args)
    {
        string path = "students.csv";
        string[] lines = File.ReadAllLines(path);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');
            int marks = int.Parse(data[3]);

            if (marks > 80)
            {
                Console.WriteLine("ID: " + data[0] +" | Name: " + data[1] +" | Marks: " + data[3]);
				
           
		   }

        }

    }

}