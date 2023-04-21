using DAL.Models.ViewModels;
using DAL.Models.DTO.ProductDTO;

namespace BLL.Interfaces
{
    public interface IProductService
    {

        public IEnumerable<ProductViewModel> GetAll();

        public ProductViewModel? GetById(int id);

        public IEnumerable<ProductViewModel> GetBySeller(int id);


        public ProductViewModel? CreateProduct(CreateProductDTO createProductDTO);


        public ProductViewModel? UpdateProduct(int id, UpdateProductDTO product);

        public bool DeleteProduct(int id);

        public ProductViewModel? BuyProduct(int id, int userId);

        public ProductViewModel? ConfirmBuyProduct(int id, bool ComfirmBuyProduct, int userId);


    }
}
