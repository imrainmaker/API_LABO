using DAL.Models;
using DAL.Models.DTO.UserDTO;
using DAL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        public List<UserViewModel> GetAll();

        public UserViewModel? GetById(int id);

        public UserViewModel? GetByEmail(string email);

        public string login(LoginUserDTO loginUserDTO);

        public UserViewModel? CreateUser(CreateUserDTO createUserDTO);

        public UserViewModel? UpdateUser(int id, UpdateUserDTO updateUserDTO);

        public UserViewModel? UpdatePwd(int id, UpdateUserPwdDTO updateUserPwdDTO);

        public UserViewModel? UpdateRole(int id, UpdateUserRoleDTO updateUserRoleDTO);

        public bool DeleteUser(int id);
    }
}
