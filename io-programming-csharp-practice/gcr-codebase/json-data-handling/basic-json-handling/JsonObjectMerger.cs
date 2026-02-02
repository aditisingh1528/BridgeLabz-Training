using System;
using Newtonsoft.Json.Linq;

class JsonObjectMerger
{
    static void Main(string[] args)
    {
        string firstJson = "{ 'name':'Aniket', 'age':23 }";
        string secondJson = "{ 'email':'aniket@gmail.com', 'city':'Pune' }";

        JObject firstJsonObject = JObject.Parse(firstJson);
        JObject secondJsonObject = JObject.Parse(secondJson);

        //Merging second object into first
        firstJsonObject.Merge(secondJsonObject);

        Console.WriteLine("Merged JSON:");
        Console.WriteLine(firstJsonObject.ToString());
    }
}
