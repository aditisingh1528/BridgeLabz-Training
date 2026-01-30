using HealthCheckPro.Annotations;

namespace HealthCheckPro.Controllers
{
    // Controller related to lab operations
    public class LabController
    {
        // Public API to fetch lab tests
        [PublicAPI("Get all available lab tests")]
        public void GetLabTests() { }

        // Public API that also requires authentication
        [PublicAPI("Book a lab test")]
        [RequiresAuth("Patient")]
        public void BookLabTest() { }

        // No annotation added (used to detect missing metadata)
        public void DeleteLabTest() { }
    }
}