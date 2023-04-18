using DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.ViewModels
{
    public class UserViewModel
    {
        public int UserId { get; set; }

        public string Email { get; set; }

        public string Street { get; set; }

        public int StreetNbr { get; set; }

        public string? StreetBox { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string? Lastname { get; set; }

        public string? Firstname { get; set; }

        public string? Phone { get; set; }

        public Roles Role { get; set; }
    }
}
