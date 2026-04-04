using System;
using System.IO;

class FileCopy
{
    static void Main(string[] args)
    {
        Console.Write("Enter source file path: ");
        string sourcePath = Console.ReadLine();
        string destinationPath = "destination.txt";

        if (!File.Exists(sourcePath))
        {
            Console.WriteLine("Source file does not exist.");
            return;
        }

        try
        {
            FileStream readStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);

            FileStream writeStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write);

            int data;
            while ((data = readStream.ReadByte()) != -1)
            {
                writeStream.WriteByte((byte)data);
            }

            readStream.Close();
            writeStream.Close();

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error occurred: " + ex.Message);
        }
    }
}
