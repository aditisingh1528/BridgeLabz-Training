using System;
using System.Text.Json;

namespace EventTracker.Logger
{
    // Handles JSON log creation
    public class JsonAuditLogger
    {
        public void GenerateLog(string action, string className, string methodName)
        {
            // Audit log data
            var log = new
            {
                Action = action,
                Class = className,
                Method = methodName,
                TimeStamp = DateTime.Now
            };

            // Convert to JSON
            string json = JsonSerializer.Serialize(
                log,
                new JsonSerializerOptions { WriteIndented = true });

            Console.WriteLine(json);
        }
    }
}