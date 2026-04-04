using System;
using System.IO;

public class FileProcessor
{
    //method to write content to file
    public void WriteToFile(string filename, string content)
    {
        File.WriteAllText(filename, content);
    }

    //method to read content from file
    public string ReadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            throw new IOException("File does not exist");
        }

        return File.ReadAllText(filename);
    }
}
