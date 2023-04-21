using DAL.Context;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.products.Include(p => p.Seller).ToList();
        }
        public Product? GetById(int id)
        {
            try
            {
                return _context.products.Include(p => p.Seller).First(p => p.ProductId == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public IEnumerable<Product> GetBySeller(int id)
        {
            try
            {
                return _context.products.Include(p => p.Seller).Where(p => p.Seller.UserId == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public User? GetUser(int id)
        {
            try
            {
                return _context.users.Find(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public Product? CreateProduct(Product product, User user)
        {
            try
            {
                _context.products.Add(product);
                _context.users.Update(user);
                _context.SaveChanges();
                return product;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public Product? UpdateProduct(Product product)
        {
            try
            {
                _context.products.Update(product);
                _context.SaveChanges();
                return product;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public bool DeleteProduct(Product product)
        {
            try
            {
                _context.products.Remove(product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
