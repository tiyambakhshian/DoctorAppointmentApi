using System.ComponentModel.DataAnnotations;

namespace DoctorAppointmentApi.Data.JWTModel.DTO;

public class LoginDTO
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
}