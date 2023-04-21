using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DAL.Models.DTO;
using DAL.Models.DTO.ProductDTO;
using DAL.Models.Mapper;
using DAL.Models.ViewModels;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<ProductViewModel> GetAll()
        {

            return _productRepository.GetAll().ToProductViewModelList();
        }

        public ProductViewModel? GetById(int id)
        {
            Product? product = _productRepository.GetById(id);
            return product is not null ? product.ToProductViewModel() : null;
        }

        public IEnumerable<ProductViewModel> GetBySeller(int id)
        {

            return _productRepository.GetBySeller(id).ToProductViewModelList();
        }


        public ProductViewModel? CreateProduct(CreateProductDTO createProductDTO)
        {
            Product? productSeller = _productRepository.GetBySeller(createProductDTO.Seller).First();
            User? seller = productSeller is not null ? productSeller.Seller : null;

            return _productRepository.CreateProduct(createProductDTO.ToProduct(seller))?.ToProductViewModel();
        }

        public ProductViewModel? UpdateProduct(int id, UpdateProductDTO product)
        {
            Product? productToUpdate = _productRepository.GetById(id);

            Product? productSeller = _productRepository.GetBySeller(product.Seller).First();
            User? seller = productSeller is not null ? productSeller.Seller : null;
            if (productToUpdate is not null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.Description = product.Description;
                productToUpdate.Price = product.Price;
                productToUpdate.Seller = seller;
                productToUpdate.Status = product.Status;

                return _productRepository.UpdateProduct(productToUpdate).ToProductViewModel();
            }
            return null;
        }

        public bool DeleteProduct(int id)
        {
            Product? productToUpdate = _productRepository.GetById(id);
            if (productToUpdate is not null)
            {

                return _productRepository.DeleteProduct(productToUpdate);
            }
            return false;
        }

    }
}
