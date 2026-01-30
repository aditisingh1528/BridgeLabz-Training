using EventTracker.Annotations;

namespace EventTracker.Actions
{
    // Represents user actions in system
    public class UserActions
    {
        [AuditTrail("User Login")]
        public void Login() { }

        [AuditTrail("File Upload")]
        public void UploadFile() { }

        [AuditTrail("File Delete")]
        public void DeleteFile() { }

        // Not audited
        public void ViewProfile() { }
    }
}