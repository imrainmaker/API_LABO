using System.ComponentModel.DataAnnotations;

namespace DAL.Models.DTO.ProductDTO
{
    public class CreateProductDTO
    {

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int Seller { get; set; }
    }
}
