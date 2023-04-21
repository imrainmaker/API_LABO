using DAL.Enums;
using DAL.Models.DTO;
using DAL.Models.DTO.ProductDTO;
using DAL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Mapper
{
    public static class ProductMapper
    {
        public static Product ToProduct(this CreateProductDTO createProduct, User seller)
        {
            return new Product
            (
                 createProduct.Name,
                 createProduct.Description,
                 createProduct.Price,
                 seller
            ); ;
        }
        public static ProductViewModel ToProductViewModel(this Product product)
        {
            return new ProductViewModel
            {

                ProductId = product.ProductId,

                Name = product.Name,

                Description = product.Description,

                Price =  product.Price,

                Status = product.Status, 

                Seller = product.Seller.ToUserViewModel()
            };
        }

        public static List<ProductViewModel> ToProductViewModelList(this IEnumerable<Product> product)
        {
            List<ProductViewModel> productViewModelList = new List<ProductViewModel>();

            foreach (Product p in product)
            {
                productViewModelList.Add(p.ToProductViewModel());
            }

            return productViewModelList;
        }
    }
}
