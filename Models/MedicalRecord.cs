 using System.ComponentModel.DataAnnotations;
namespace WebCWK.Models
{
    public class MedicalRecord
    {

        [Key] public int RecordId { get; set; } //Primary key
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime RecordDate { get; set; }
        public string Diagnosis { get; set; }
        public string Prescription { get; set; }
    }
}
