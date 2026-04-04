using System;

namespace HealthCheckPro.Annotations
{
    // Custom annotation for marking public APIs
    [AttributeUsage(AttributeTargets.Method)]
    public class PublicAPIAttribute : Attribute
    {
        // Description of the API
        public string Description { get; }

        // Constructor to accept description
        public PublicAPIAttribute(string description)
        {
            Description = description;
        }
    }
}