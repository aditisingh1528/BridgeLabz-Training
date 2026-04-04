using System;
using System.IO;

class ImageByteArray
{
    static void Main(string[] args)
    {
        Console.Write("Enter source image path: ");
        string sourcePath = Console.ReadLine();

        string destinationPath = "copiedImage.jpg";

        if (!File.Exists(sourcePath))
        {
            Console.WriteLine("Source image does not exist.");
            return;
        }

        try
        {
            byte[] imageBytes = File.ReadAllBytes(sourcePath);

            MemoryStream ms = new MemoryStream(imageBytes);

            FileStream fs = new FileStream(destinationPath, FileMode.Create, FileAccess.Write);
            ms.WriteTo(fs);

            fs.Close();
            ms.Close();

            FileInfo original = new FileInfo(sourcePath);
            FileInfo copied = new FileInfo(destinationPath);

            if (original.Length == copied.Length)
            {
                Console.WriteLine("Image copied successfully and verified.");
            }
            else
            {
                Console.WriteLine("Image copy failed verification.");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error occurred: " + ex.Message);
        }
    }
}
