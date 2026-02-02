using System;
using System.IO;
using Newtonsoft.Json.Linq;

class JsonFileMerger
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first JSON file path:");
        string firstFilePath = Console.ReadLine();

        Console.WriteLine("Enter second JSON file path:");
        string secondFilePath = Console.ReadLine();

        JObject firstJsonObject = JObject.Parse(File.ReadAllText(firstFilePath));
        JObject secondJsonObject = JObject.Parse(File.ReadAllText(secondFilePath));

        //Merging JSON objects
        firstJsonObject.Merge(secondJsonObject);

        Console.WriteLine("Merged JSON:");
        Console.WriteLine(firstJsonObject.ToString());
    }
}
