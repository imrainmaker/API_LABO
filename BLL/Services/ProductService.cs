using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
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

    }
}
