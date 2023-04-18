using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Enums;

namespace DAL.Models
{
    public class User
    {
        public User()
        {

        }

        public User(string email, string password, string street, int streetNbr, string? streetBox, string zipCode, string city, string country, string? lastname, string? firstname, string? phone, Roles role = Roles.user)
        {
 
            Email = email;
            Password = password;
            Street = street;
            StreetNbr = streetNbr;
            StreetBox = streetBox;
            ZipCode = zipCode;
            City = city;
            Country = country;
            Lastname = lastname;
            Firstname = firstname;
            Phone = phone;
            Role = role;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!]).{8,25}$")]
        public string Password { get; set; }

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

        [Required]
        public Roles Role { get; set; }


    }
}
