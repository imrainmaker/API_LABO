using DAL.Enums;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models.DTO.UserDTO
{
    public class UpdateUserRoleDTO
    {
        [Required]
        public Roles Role { get; set; }
    }
}
