using DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using DAL.Models.ViewModels;

namespace DAL.Models
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId, string name, string description, decimal price, User? seller, ProductStatus status)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            Price = price;
            Seller = seller;
            Status = status;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }


        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public ProductStatus Status { get; set; }

        public User? Seller { get; set; }

    }
}
