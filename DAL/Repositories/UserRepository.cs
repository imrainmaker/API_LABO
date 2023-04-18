using DAL.Context;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.users.ToList();
        }
        public User? GetById(int id)
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

        public User? GetByEmail(string email)
        {
            try
            {

                User? user = _context.users.First(x => x.Email == email);
                return user is not null ? user : null;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public User CreateUser(User user)
        {
            try
            {
                _context.users.Add(user);
                _context.SaveChanges();
                return user;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public User UpdateUser(User user)
        {
            try
            {
                _context.users.Update(user);
                _context.SaveChanges();
                return user;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public bool DeleteUser(User user)
        {
            try
            {
                _context.users.Remove(user);
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
