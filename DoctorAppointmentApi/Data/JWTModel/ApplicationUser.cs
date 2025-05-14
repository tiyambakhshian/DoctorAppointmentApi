using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DoctorAppointmentApi.Data.JWTModel;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; }
    public int? Age { get; set; }
}