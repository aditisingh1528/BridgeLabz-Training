using System;
using System.Text.Json;

namespace EventTracker.Logger
{
    // Creates JSON audit logs
    public class JsonAuditLogger
    {
        public void Log(string action, string className, string methodName)
        {
            var auditData = new
            {
                Action = action,
                Class = className,
                Method = methodName,
                TimeStamp = DateTime.Now
            };

            // Convert to JSON and print
            string json = JsonSerializer.Serialize(
                auditData,
                new JsonSerializerOptions { WriteIndented = true });

            Console.WriteLine(json);
        }
    }
}