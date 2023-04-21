using DAL.Enums;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models.DTO.ProductDTO
{
    public class UpdateProductDTO
    {

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

        public int Seller { get; set; }
    }
}
