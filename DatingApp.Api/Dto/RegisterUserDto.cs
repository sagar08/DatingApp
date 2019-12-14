using System.ComponentModel.DataAnnotations;

namespace DatingApp.Dto
{
    public class RegisterUserDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Specify the password between 4 to 8 characters")]
        public string Password { get; set; }
    }

    public class LoginUserDto : RegisterUserDto { }
}