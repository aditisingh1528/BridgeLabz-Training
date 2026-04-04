using System;
using System.Linq;
using System.Reflection;
using HealthCheckPro.Annotations;

namespace HealthCheckPro.Scanner
{
    // Class responsible for scanning controllers
    public class ApiScanner
    {
        // Method to scan all APIs using reflection
        public void ScanControllers()
        {
            Console.WriteLine("\nScanning API Controllers...\n");

            // Get current assembly
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Find all classes ending with Controller
            var controllers = assembly.GetTypes()
                .Where(type => type.Name.EndsWith("Controller"));

            foreach (var controller in controllers)
            {
                Console.WriteLine($"Controller: {controller.Name}");

                // Get only public methods of controller
                var methods = controller.GetMethods(
                    BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

                foreach (var method in methods)
                {
                    // Check if annotations are present
                    bool hasPublicApi =
                        method.GetCustomAttribute<PublicAPIAttribute>() != null;

                    bool hasAuth =
                        method.GetCustomAttribute<RequiresAuthAttribute>() != null;

                    // If no annotations found
                    if (!hasPublicApi && !hasAuth)
                    {
                        Console.WriteLine($" ❌ {method.Name} → Missing annotations");
                    }
                    else
                    {
                        Console.WriteLine($" ✅ {method.Name} → Valid");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}