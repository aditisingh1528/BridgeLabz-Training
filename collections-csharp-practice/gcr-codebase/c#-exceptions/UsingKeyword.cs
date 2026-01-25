using System;
using System.IO;

class UsingKeyword
{
    static void Main(string[] args)
    {
        try
        {
            using (StreamReader reader = new StreamReader("info.txt"))
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
		
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}