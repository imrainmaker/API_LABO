using DAL.Enums;

namespace DAL.Models.ViewModels
{
    public class ProductViewModel
    {

        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public ProductStatus Status { get; set; }

        public UserViewModel? Seller { get; set; }
    }
}
