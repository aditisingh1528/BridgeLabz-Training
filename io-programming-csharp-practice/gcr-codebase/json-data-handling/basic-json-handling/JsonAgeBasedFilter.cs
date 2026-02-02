using System;
using Newtonsoft.Json.Linq;

class JsonAgeBasedFilter
{
    static void Main(string[] args)
    {
        string jsonData = @"[
            { 'name':'Amit', 'age':22 },
            { 'name':'Ravi', 'age':30 },
            { 'name':'Neha', 'age':28 }
        ]";

        JArray jsonArray = JArray.Parse(jsonData);

        Console.WriteLine("Users with age greater than 25:");

        //Filtering records based on age condition
        foreach (var record in jsonArray)
        {
            if ((int)record["age"] > 25)
            {
                Console.WriteLine(record["name"]);
            }
        }
    }
}
