using System.ComponentModel.DataAnnotations;

namespace DAL.Models.DTO.UserDTO
{
    public class LoginUserDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
