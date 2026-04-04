using System;
using System.Linq;
using System.Reflection;
using EventTracker.Annotations;
using EventTracker.Logger;

namespace EventTracker.Tracker
{
    // Scans methods using reflection
    public class AuditScanner
    {
        private readonly JsonAuditLogger logger = new JsonAuditLogger();

        public void ScanAuditedMethods()
        {
            Console.WriteLine("\nScanning audited methods...\n");

            Assembly assembly = Assembly.GetExecutingAssembly();

            // Scan all types in assembly
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                var methods = type.GetMethods(
                    BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

                foreach (var method in methods)
                {
                    // Check for AuditTrail annotation
                    var auditAttr =
                        method.GetCustomAttribute<AuditTrailAttribute>();

                    if (auditAttr != null)
                    {
                        logger.GenerateLog(
                            auditAttr.ActionName,
                            type.Name,
                            method.Name);
                    }
                }
            }
        }
    }
}