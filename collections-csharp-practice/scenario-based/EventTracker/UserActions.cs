using EventTracker.Annotations;

namespace EventTracker.Actions
{
    // Class containing user related actions
    public class UserActions
    {
        [AuditTrail("User Login")]
        public void Login() { }

        [AuditTrail("File Upload")]
        public void UploadFile() { }

        [AuditTrail("Delete File")]
        public void DeleteFile() { }

        // This method is not audited
        public void ViewDashboard() { }
    }
}