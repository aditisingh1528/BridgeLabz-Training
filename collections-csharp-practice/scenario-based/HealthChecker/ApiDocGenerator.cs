using System;
using System.Linq;
using System.Reflection;
using HealthCheckPro.Annotations;

namespace HealthCheckPro.Documentation
{
    // Class to auto-generate API documentation
    public class ApiDocGenerator
    {
        // Method to generate docs
        public void GenerateDocs()
        {
            Console.WriteLine("\nAuto-Generated API Documentation\n");

            // Get current assembly
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Get all controller classes
            var controllers = assembly.GetTypes()
                .Where(type => type.Name.EndsWith("Controller"));

            foreach (var controller in controllers)
            {
                Console.WriteLine($"=== {controller.Name} ===");

                // Get controller methods
                var methods = controller.GetMethods(
                    BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

                foreach (var method in methods)
                {
                    // Read annotations using reflection
                    var publicApi =
                        method.GetCustomAttribute<PublicAPIAttribute>();

                    var auth =
                        method.GetCustomAttribute<RequiresAuthAttribute>();

                    Console.WriteLine($"Method: {method.Name}");

                    // Print description if available
                    if (publicApi != null)
                        Console.WriteLine($" Description: {publicApi.Description}");

                    // Print role if authentication is required
                    if (auth != null)
                        Console.WriteLine($" Authorization: {auth.Role}");

                    Console.WriteLine();
                }
            }
        }
    }
}