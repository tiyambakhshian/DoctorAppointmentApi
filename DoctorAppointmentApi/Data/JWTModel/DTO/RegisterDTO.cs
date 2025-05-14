using System.ComponentModel.DataAnnotations;

namespace DoctorAppointmentApi.Data.JWTModel.DTO;

public class RegisterDTO
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    public int? Age { get; set; }
}