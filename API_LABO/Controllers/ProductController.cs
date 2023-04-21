using BLL.Interfaces;
using BLL.Services;
using DAL.Context;
using DAL.Models;
using DAL.Models.DTO;
using DAL.Models.DTO.ProductDTO;
using DAL.Models.Mapper;
using DAL.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace API_LABO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]

        public ActionResult<IEnumerable<ProductViewModel>> Get()
        {
            return Ok(_productService.GetAll());
        }

        [HttpGet("{id}")]

        public ActionResult<ProductViewModel> GetById(int id)
        {
            if (ModelState.IsValid)
            {
                ProductViewModel? productVM = _productService.GetById(id);
                return productVM is not null ? Ok(productVM) : BadRequest();
            }

            return BadRequest();
        }

        [HttpGet("seller/{id}")]

        public ActionResult<IEnumerable<ProductViewModel>> GetBySeller(int id)
        {
            if (ModelState.IsValid)
            {
                IEnumerable<ProductViewModel> productVM = _productService.GetBySeller(id);
                return productVM is not null ? Ok(productVM) : BadRequest();
            }

            return BadRequest();
        }


        [HttpPost]
        public ActionResult<ProductViewModel?> CreateProduct(CreateProductDTO createProductDTO)
        {

            if (ModelState.IsValid)
            {
                ProductViewModel? productVM = _productService.CreateProduct(createProductDTO);
                return productVM is not null ? Ok(productVM) : BadRequest();
            }

            return BadRequest();
        }


        [HttpPut("{id}")]
        public ActionResult<ProductViewModel?> UpdateProduct(int id, UpdateProductDTO updateProductDTO)
        {

            if (ModelState.IsValid)
            {
                ProductViewModel? productVM = _productService.UpdateProduct(id, updateProductDTO);
                return productVM is not null ? Ok(productVM) : BadRequest();
            }

            return BadRequest();
        }


        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteProduct(int id)
        {
            if (ModelState.IsValid)
            {
                bool productVM = _productService.DeleteProduct(id);
                return productVM is true ? Ok(productVM) : BadRequest();
            }

            return BadRequest();
        }
    }
}
