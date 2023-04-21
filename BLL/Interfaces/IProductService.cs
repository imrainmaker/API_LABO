using DAL.Models.DTO;
using DAL.Models;
using DAL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public ProductViewModel? BuyProduct(int id);

        public ProductViewModel? ConfirmBuyProduct(int id, bool ComfirmBuyProduct);


    }
}
