using DAL.Context;
using DAL.Models;
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
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]

        public ActionResult<Product?> GetById(int id)
        {
     
            return _context.products.Include(p => p.Seller).First(p => p.ProductId == id);
        }
    }
}
