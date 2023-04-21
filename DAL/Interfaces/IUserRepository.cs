using DAL.Models;

namespace DAL.Interfaces
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAll();

        public User? GetById(int id);

        public User? GetByEmail(string email);

        public User CreateUser(User user);

        public User UpdateUser(User user);

        public bool DeleteUser(User user);
    }
}
