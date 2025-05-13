namespace DoctorAppointmentApi.Data.Model
{
    public class WorkingHour
    {
        public int Id { get; set; }

        public int DoctorProfileId { get; set; }     // FK به DoctorProfile

        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public DoctorProfile DoctorProfile { get; set; }     // Navigation
    }


}
