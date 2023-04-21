using DAL.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Product
    {
        public Product()
        {

        }

        public Product(string name, string description, decimal price, User? seller, ProductStatus status = ProductStatus.ForSale)
        {
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
