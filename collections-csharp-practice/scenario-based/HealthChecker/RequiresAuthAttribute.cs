using System;

namespace HealthCheckPro.Annotations
{
    // Custom annotation for APIs that need authentication
    [AttributeUsage(AttributeTargets.Method)]
    public class RequiresAuthAttribute : Attribute
    {
        // Role required to access API
        public string Role { get; }

        // Constructor to accept role
        public RequiresAuthAttribute(string role)
        {
            Role = role;
        }
    }
}