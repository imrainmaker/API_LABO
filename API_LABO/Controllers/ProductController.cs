using BLL.Interfaces;
using BLL.Services;
using DAL.Context;
using DAL.Models;
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
    }
}
