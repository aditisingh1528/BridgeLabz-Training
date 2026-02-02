using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class EmailSchemaValidator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter email:");
        string emailInput = Console.ReadLine();

        string emailSchema = @"{
          'type': 'object',
          'properties': {
            'email': {
              'type': 'string',
              'format': 'email'
            }
          },
          'required': ['email']
        }";

        JObject emailObject = JObject.Parse("{ 'email': '" + emailInput + "' }");
        JSchema schemaDefinition = JSchema.Parse(emailSchema);

        //Validating email format
        bool validationResult = emailObject.IsValid(schemaDefinition);

        Console.WriteLine(validationResult ? "Email is valid" : "Email is invalid");
    }
}
