using System;

namespace EventTracker.Annotations
{
    // Custom annotation to mark audit actions
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