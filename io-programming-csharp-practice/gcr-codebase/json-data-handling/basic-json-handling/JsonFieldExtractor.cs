using System;
using System.IO;
using Newtonsoft.Json.Linq;

class JsonFieldExtractor
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter JSON file path:");
        string jsonFilePath = Console.ReadLine();

        string jsonContent = File.ReadAllText(jsonFilePath);
        JObject jsonObject = JObject.Parse(jsonContent);

        //Extracting required fields
        string nameValue = jsonObject["name"]?.ToString();
        string emailValue = jsonObject["email"]?.ToString();

        Console.WriteLine("Name: " + nameValue);
        Console.WriteLine("Email: " + emailValue);
    }
}
