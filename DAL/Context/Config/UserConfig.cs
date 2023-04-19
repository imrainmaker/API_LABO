using DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Enums;

namespace DAL.Context.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasCheckConstraint("CK_Email", "[Email] LIKE '%@%.%'");
            builder.HasIndex(u => u.Email).IsUnique();
            builder.HasData(
                            new User
                            {
                                UserId = 1,
                                Email = "jeremy.bazin@email.com",
                                Password = "Test123=",
                                Street = "Rue de la Paix",
                                StreetNbr = 10,
                                ZipCode = "1000",
                                City = "Brussels",
                                Country = "Belgium",
                                Lastname = "Bazin",
                                Firstname = "Jeremy",
                                Phone = "+32 2 123 45 67",
                                Role = Roles.admin,
                                
                            },
                            new User
                            {
                                UserId = 2,
                                Email = "bob.martin@email.com",
                                Password = "5Gh#zBvKw3PxYrE",
                                Street = "Main Street",
                                StreetNbr = 25,
                                ZipCode = "12345",
                                City = "New York",
                                Country = "USA",
                                Lastname = "Martin",
                                Firstname = "Bob",
                                Phone = "+1 123-456-7890",
                                Role = Roles.seller,
                                
                            },
                            new User
                            {
                                UserId = 3,
                                Email = "charlie.nguyen@email.com",
                                Password = "fT7#eRm2QxLz9Dy$",
                                Street = "Highway Road",
                                StreetNbr = 50,
                                ZipCode = "67890",
                                City = "Los Angeles",
                                Country = "USA",
                                Lastname = "Nguyen",
                                Firstname = "Charlie",
                                Phone = "+1 234-567-8901",
                                Role = Roles.user,
                                
                            },
                            new User
                            {
                                UserId = 4,
                                Email = "david.lee@email.com",
                                Password = "V6b$UwPcNz @hM8xK",
                                Street = "Oxford Street",
                                StreetNbr = 15,
                                ZipCode = "W1D 1BS",
                                City = "London",
                                Country = "UK",
                                Lastname = "Lee",
                                Firstname = "David",
                                Phone = "+44 20 1234 5678",
                                Role = Roles.seller,
                                
                            },
                            new User
                            {
                                UserId = 5,
                                Email = "emma.garcia@email.com",
                                Password = "aH5%kXjL9$qBm2W",
                                Street = "Carrer de Balmes",
                                StreetNbr = 12,
                                ZipCode = "08007",
                                City = "Barcelona",
                                Country = "Spain",
                                Lastname = "Garcia",
                                Firstname = "Emma",
                                Phone = "+34 93 123 45 67",
                                Role = Roles.user,
                                
                            },
                            new User
                            {
                                UserId = 6,
                                Email = "frank.chen@email.com",
                                Password = "qJ9@fM8cWu5$xLrE",
                                Street = "Nanjing Road",
                                StreetNbr = 100,
                                ZipCode = "200000",
                                City = "Shanghai",
                                Country = "China",
                                Lastname = "Chen",
                                Firstname = "Frank",
                                Phone = "+86 21 1234 5678",
                                Role = Roles.seller,
                                
                            },
                            new User
                            {
                                UserId = 7,
                                Email = "grace.wong@email.com",
                                Password = "7Km&zRb#vGy2hNj",
                                Street = "3 Main St",
                                StreetNbr = 35,
                                StreetBox = null,
                                ZipCode = "1000",
                                City = "Brussels",
                                Country = "Belgium",
                                Lastname = "Wong",
                                Firstname = "Grace",
                                Phone = "555-1234",
                                Role = Roles.seller
                            },
                            new User
                            {
                                UserId = 8,
                                Email = "henry.zhang@email.com",
                                Password = "T4c#nSv@wGj2RkF",
                                Street = "9 High St",
                                StreetNbr = 45,
                                StreetBox = null,
                                ZipCode = "1000",
                                City = "Brussels",
                                Country = "Belgium",
                                Lastname = "Zhang",
                                Firstname = "Henry",
                                Phone = "555-1234",
                                Role = Roles.user
                            },
                            new User
                            {
                                UserId = 9,
                                Email = "isabella.lopez@email.com",
                                Password = "H8f$kL3q#sVp9Xy",
                                Street = "12 Park Ave",
                                StreetNbr = 24,
                                StreetBox = null,
                                ZipCode = "1000",
                                City = "Brussels",
                                Country = "Belgium",
                                Lastname = "Lopez",
                                Firstname = "Isabella",
                                Phone = "555-1234",
                                Role = Roles.user
                            },
                            new User
                            {
                                UserId = 10,
                                Email = "jack.kim@email.com",
                                Password = "3ZgY*6tLx#pVfDhN",
                                Street = "15 Rue de la Loi",
                                StreetNbr = 4,
                                StreetBox = null,
                                ZipCode = "1000",
                                City = "Brussels",
                                Country = "Belgium",
                                Lastname = "Kim",
                                Firstname = "Jack",
                                Phone = "555-1234",
                                Role = Roles.seller
                            }
                        );
        }
    }
}
