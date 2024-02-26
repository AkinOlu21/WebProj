using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebCWK.Models
{
    public class Appointment
    {

        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        
        [JsonIgnore]
        public string? Status { get; set; }
    }
}
