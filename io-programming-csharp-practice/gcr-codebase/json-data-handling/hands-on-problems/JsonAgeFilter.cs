using System;
using Newtonsoft.Json.Linq;

class JsonAgeFilter
{
    static void Main(string[] args)
    {
        string jsonData = @"[
            { 'name': 'Amit', 'age': 22 },
            { 'name': 'Ravi', 'age': 30 },
            { 'name': 'Neha', 'age': 28 }
        ]";

        JArray userArray = JArray.Parse(jsonData);

        Console.WriteLine("Users older than 25:");

        //Filtering users based on age
        foreach (var user in userArray)
        {
            if ((int)user["age"] > 25)
            {
                Console.WriteLine(user["name"]);
            }
        }
    }
}
