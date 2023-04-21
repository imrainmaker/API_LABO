using DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.DTO.UserDTO
{
    public class UpdateUserRoleDTO
    {
        [Required]
        public Roles Role { get; set; }
    }
}
