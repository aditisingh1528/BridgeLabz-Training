using System;

namespace EventTracker.Annotations
{
    // Annotation to mark methods for audit logging
    [AttributeUsage(AttributeTargets.Method)]
    public class AuditTrailAttribute : Attribute
    {
        public string ActionName { get; }

        public AuditTrailAttribute(string actionName)
        {
            ActionName = actionName;
        }
    }
}