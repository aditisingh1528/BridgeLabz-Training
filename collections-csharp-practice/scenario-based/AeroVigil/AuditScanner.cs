using System.Reflection;
using EventTracker.Annotations;
using EventTracker.Logger;

namespace EventTracker.Tracker
{
    // Scans methods using reflection
    public class AuditScanner
    {
        private readonly JsonAuditLogger logger = new JsonAuditLogger();

        public void ScanAndLog()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Scan all classes
            foreach (var type in assembly.GetTypes())
            {
                // Scan public methods
                var methods = type.GetMethods(
                    BindingFlags.Public |
                    BindingFlags.Instance |
                    BindingFlags.DeclaredOnly);

                foreach (var method in methods)
                {
                    // Check for AuditTrail annotation
                    var audit =
                        method.GetCustomAttribute<AuditTrailAttribute>();

                    if (audit != null)
                    {
                        logger.Log(
                            audit.ActionName,
                            type.Name,
                            method.Name);
                    }
                }
            }
        }
    }
}