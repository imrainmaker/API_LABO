﻿using BLL.Interfaces;
using DAL.Enums;
using DAL.Interfaces;
using DAL.Models;
using DAL.Models.DTO.ProductDTO;
using DAL.Models.Mapper;
using DAL.Models.ViewModels;

namespace BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IInvoiceRepository _invoiceRepository;

        public ProductService(IProductRepository productRepository, IInvoiceRepository invoiceRepository)
        {
            _productRepository = productRepository;
            _invoiceRepository = invoiceRepository;
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
   
            User? seller = _productRepository.GetUser(createProductDTO.Seller);

            if (seller.Role == Roles.user)
            {
                seller.Role = Roles.seller;
            }

            return _productRepository.CreateProduct(createProductDTO.ToProduct(seller), seller)?.ToProductViewModel();
        }

        public ProductViewModel? UpdateProduct(int id, UpdateProductDTO product)
        {
            Product? productToUpdate = _productRepository.GetById(id);

            User? seller = _productRepository.GetUser(product.Seller);
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

        public ProductViewModel? BuyProduct(int id, int userId)
        {
            Product? productToUpdate = _productRepository.GetById(id);
            User? user = _productRepository.GetUser(userId);

            if (productToUpdate is not null && productToUpdate.Status == ProductStatus.ForSale)
            {

                productToUpdate.Status = ProductStatus.AwaitingConfirmation;
                Invoice invoice = new Invoice
                {
                    Buyer = user,
                    Product = productToUpdate,
                    Price = productToUpdate.Price,
                    DeliveryAddress = $"{user.Street} {user.StreetNbr} {user.StreetBox}, {user.ZipCode} {user.City}, {user.Country}",
                    Date = DateTime.Now,
                    Status = InvoiceStatus.Open
                };

                _invoiceRepository.CreateInvoice(invoice);

                return _productRepository.UpdateProduct(productToUpdate).ToProductViewModel();
            }
            return null;
        }

    

        public ProductViewModel? ConfirmBuyProduct(int id, bool ComfirmBuyProduct, int userId)
        {
            Product? productToUpdate = _productRepository.GetById(id);
            Invoice? invoice= _invoiceRepository.GetByProduct(id);

            if (productToUpdate is not null && productToUpdate.Status == ProductStatus.AwaitingConfirmation)
            {

                if (ComfirmBuyProduct)
                {
                    invoice.Status = InvoiceStatus.Closed;
                    productToUpdate.Status = ProductStatus.Sold;
                }
                else 
                {
                    invoice.Status = InvoiceStatus.Denied;
                    productToUpdate.Status = ProductStatus.ForSale;
                }

                _invoiceRepository.ConfirmInvoice(invoice);

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
