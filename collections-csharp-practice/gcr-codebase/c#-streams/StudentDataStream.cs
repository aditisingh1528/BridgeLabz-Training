using System;
using System.IO;

class StudentDataStream
{
    static void Main(string[] args)
    {
        string filePath = "student.dat";

        Console.Write("Enter roll number: ");
        int rollNo = int.Parse(Console.ReadLine());

        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter GPA: ");
        double gpa = double.Parse(Console.ReadLine());

        WriteStudentData(filePath, rollNo, name, gpa);
        ReadStudentData(filePath);
    }

    static void WriteStudentData(string path, int rollNo, string name, double gpa)
    {
        try
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(fs);

            writer.Write(rollNo);
            writer.Write(name);
            writer.Write(gpa);

            writer.Close();
            fs.Close();

            Console.WriteLine("Student data stored successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Write error: " + ex.Message);
        }
    }

    static void ReadStudentData(string path)
    {
        try
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryReader reader = new BinaryReader(fs);

            int rollNo = reader.ReadInt32();
            string name = reader.ReadString();
            double gpa = reader.ReadDouble();

            reader.Close();
            fs.Close();

            Console.WriteLine("Retrieved Student Data:");
            Console.WriteLine(rollNo + " " + name + " " + gpa);
        }
        catch (IOException ex)
        {
            Console.WriteLine("Read error: " + ex.Message);
        }
    }
}
