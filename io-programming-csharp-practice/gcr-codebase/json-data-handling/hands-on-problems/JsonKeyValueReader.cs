using System;
using System.IO;
using Newtonsoft.Json.Linq;

class JsonKeyValueReader
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter JSON file path:");
        string jsonFilePath = Console.ReadLine();

        string jsonContent = File.ReadAllText(jsonFilePath);

        JObject jsonObject = JObject.Parse(jsonContent);

        //Iterating through keys and values
        foreach (var property in jsonObject)
        {
            Console.WriteLine(property.Key + " : " + property.Value);
        }
    }
}
