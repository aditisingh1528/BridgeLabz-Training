using HealthCheckPro.Annotations;

namespace HealthCheckPro.Controllers
{
    // Controller related to patient operations
    public class PatientController
    {
        // Public API for patient registration
        [PublicAPI("Register new patient")]
        public void RegisterPatient() { }

        // API accessible only by doctors
        [RequiresAuth("Doctor")]
        public void ViewPatientHistory() { }
    }
}