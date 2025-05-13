namespace DoctorAppointmentApi.Data.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // "Doctor" or "Patient"

        public DoctorProfile DoctorProfile { get; set; }     // یک‌به‌یک با پزشک
        public ICollection<Appointment> PatientAppointments { get; set; }  // نوبت‌هایی که به عنوان بیمار گرفته
        public ICollection<Appointment> DoctorAppointments { get; set; }   // نوبت‌هایی که به عنوان پزشک ثبت شده
    }


}
