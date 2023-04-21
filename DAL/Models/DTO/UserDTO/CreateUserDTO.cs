using DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.DTO.UserDTO
{
    public class CreateUserDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!]).{8,25}$")]
        public string Password { get; set; }

        [Compare("Password")]
        public string CheckPassword { get; set; }

        [Required]
        [MaxLength(100)]
        public string Street { get; set; }

        [Required]
        public int StreetNbr { get; set; }

        public string? StreetBox { get; set; }

        [Required]
        public string ZipCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength(100)]
        public string Country { get; set; }

        [MaxLength(100)]
        public string? Lastname { get; set; }

        [MaxLength(100)]
        public string? Firstname { get; set; }
        public string? Phone { get; set; }




    }
}

