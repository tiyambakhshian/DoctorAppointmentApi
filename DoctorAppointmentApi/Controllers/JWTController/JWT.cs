using DoctorAppointmentApi.Data.JWTModel;
using DoctorAppointmentApi.Data.JWTModel.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DoctorAppointmentApi.Service;
namespace DoctorAppointmentApi.Controllers.JWTController;

[Route("api/v1/JWT")]
[ApiController]
public class JWT : ControllerBase
{
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly JWTService _jwtservices;
        
        public JWT(JWTService jwtservices,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<ApplicationRole> roleManager)
        { 
            _jwtservices = jwtservices;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        
        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = new ApplicationUser
            {
                UserName = model.UserName,
                Email = model.Email,
                FullName = model.Name,
                Age = model.Age
            };
            var newuser = await _userManager.CreateAsync(user, model.Password);
            if (newuser.Succeeded)
            {
                var token = _jwtservices.GenerateJwtToken(model.UserName);
                return Ok(new { token });
            }
            return BadRequest();
        }




        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //finde the username in usermanager
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                ModelState.AddModelError("UserName", "The UserName Is Invalid");
                return BadRequest(ModelState);
            }
            //check the password 
            var checkpassword = await _userManager.CheckPasswordAsync(user, model.Password);
            if (!checkpassword)
            {
                ModelState.AddModelError("Password", "The Password Is Invalid");
                return BadRequest(ModelState);
            }

            var token = _jwtservices.GenerateJwtToken(model.UserName);
            return Ok(new { token });

            //await _signInManager.SignInWithClaimsAsync(user, true, additionalClaims);
        }
}