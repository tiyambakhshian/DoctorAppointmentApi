namespace DoctorAppointmentApi.Controllers.Data.Model
{
    public class Appointment
    {
        public int Id { get; set; }

        public int DoctorId { get; set; }        // FK به User با نقش پزشک
        public User Doctor { get; set; }

        public int PatientId { get; set; }       // FK به User با نقش بیمار
        public User Patient { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public bool IsCancelled { get; set; }
    }

}
