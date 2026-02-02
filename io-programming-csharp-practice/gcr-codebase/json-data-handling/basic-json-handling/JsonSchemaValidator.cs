using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class JsonSchemaValidator
{
    static void Main(string[] args)
    {
        string schemaDefinition = @"{
          'type': 'object',
          'properties': {
            'name': { 'type': 'string' },
            'age': { 'type': 'integer' }
          },
          'required': ['name', 'age']
        }";

        Console.WriteLine("Enter name:");
        string inputName = Console.ReadLine();

        Console.WriteLine("Enter age:");
        int inputAge = int.Parse(Console.ReadLine());

        JObject jsonData = new JObject
        {
            { "name", inputName },
            { "age", inputAge }
        };

        JSchema jsonSchema = JSchema.Parse(schemaDefinition);

        //Validating JSON structure
        bool isJsonValid = jsonData.IsValid(jsonSchema);

        Console.WriteLine(isJsonValid ? "JSON is valid" : "JSON is invalid");
    }
}
