using System;
using System.IO;
using System.Diagnostics;

class BufferedFileCopy
{
    static void Main(string[] args)
    {
        Console.Write("Enter source file path: ");
        string sourcePath = Console.ReadLine();

        string normalDest = "normalCopy.dat";
        string bufferedDest = "bufferedCopy.dat";

        if (!File.Exists(sourcePath))
        {
            Console.WriteLine("Source file does not exist.");
            return;
        }

        CopyUsingNormalStream(sourcePath, normalDest);
        CopyUsingBufferedStream(sourcePath, bufferedDest);
    }

    //method to copy file using normal FileStream
    static void CopyUsingNormalStream(string source, string dest)
    {
        Stopwatch sw = new Stopwatch();
        byte[] buffer = new byte[4096];

        try
        {
            FileStream readStream = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream writeStream = new FileStream(dest, FileMode.Create, FileAccess.Write);

            sw.Start();
            int bytesRead;
            while ((bytesRead = readStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                writeStream.Write(buffer, 0, bytesRead);
            }
            sw.Stop();

            readStream.Close();
            writeStream.Close();

            Console.WriteLine("Normal FileStream Time(ms): " + sw.ElapsedMilliseconds);
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }

    //method to copy file using BufferedStream
    static void CopyUsingBufferedStream(string source, string dest)
    {
        Stopwatch sw = new Stopwatch();
        byte[] buffer = new byte[4096];

        try
        {
            FileStream readFs = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream writeFs = new FileStream(dest, FileMode.Create, FileAccess.Write);

            BufferedStream readStream = new BufferedStream(readFs);
            BufferedStream writeStream = new BufferedStream(writeFs);

            sw.Start();
            int bytesRead;
            while ((bytesRead = readStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                writeStream.Write(buffer, 0, bytesRead);
            }
            sw.Stop();

            readStream.Close();
            writeStream.Close();

            Console.WriteLine("BufferedStream Time(ms): " + sw.ElapsedMilliseconds);
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}
