namespace DoctorAppointmentApi.Data.Model
{
    public class DoctorProfile
    {
        public int Id { get; set; }
        public int UserId { get; set; }              // Foreign Key به User

        public TimeSpan VisitDuration { get; set; }  // مدت هر ویزیت
        public User User { get; set; }               // Navigation به User
        public ICollection<WorkingHour> WorkingHours { get; set; }  // ساعات کاری
    }

}
