using System;
using System.IO;
using System.Text;

class FilterStream
{
    static void Main(string[] args)
    {
        Console.Write("Enter source file path: ");
        string sourcePath = Console.ReadLine();

        string destinationPath = "lowercase.txt";

        if (!File.Exists(sourcePath))
        {
            Console.WriteLine("Source file does not exist.");
            return;
        }

        try
        {
            FileStream readFs = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);
            BufferedStream bufferedRead = new BufferedStream(readFs);
            StreamReader reader = new StreamReader(bufferedRead, Encoding.UTF8);
			
            FileStream writeFs = new FileStream(destinationPath, FileMode.Create, FileAccess.Write);
            BufferedStream bufferedWrite = new BufferedStream(writeFs);
            StreamWriter writer = new StreamWriter(bufferedWrite, Encoding.UTF8);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line.ToLower());
            }

            reader.Close();
            writer.Close();

            Console.WriteLine("File converted to lowercase successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error occurred: " + ex.Message);
        }
    }
}
