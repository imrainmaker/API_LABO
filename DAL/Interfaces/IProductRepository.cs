using DAL.Models;

namespace DAL.Interfaces
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAll();

        public Product? GetById(int id);

        public IEnumerable<Product> GetBySeller(int id);

        public User? GetUser(int id);

        public Product? CreateProduct(Product product, User user);


        public Product? UpdateProduct(Product product);


        public bool DeleteProduct(Product product);

    }
}
