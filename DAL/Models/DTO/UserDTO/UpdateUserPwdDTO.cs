using System.ComponentModel.DataAnnotations;

namespace DAL.Models.DTO.UserDTO
{
    public class UpdateUserPwdDTO
    {
        [Required]
        public string Password { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!]).{8,25}$")]
        public string NewPassword { get; set; }

        [Compare("NewPassword")]
        public string CheckPassword { get; set; }
    }
}
