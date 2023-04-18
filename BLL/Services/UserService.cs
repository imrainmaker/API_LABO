using BLL.Interfaces;
using DAL.Enums;
using DAL.Interfaces;
using DAL.Models;
using DAL.Models.DTO;
using DAL.Models.Mapper;
using DAL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtService _jwtService;

        public UserService(IUserRepository userRepository, IJwtService jwtService)
        {
            _userRepository = userRepository;
            _jwtService = jwtService;
        }

        public List<UserViewModel> GetAll()
        {
            return _userRepository.GetAll().ToUserViewModelList();
        }
        public UserViewModel? GetById(int id)
        {

            User? user = _userRepository.GetById(id);
            return user is not null ? user.ToUserViewModel() : null;
        }

        public UserViewModel? GetByEmail(string email)
        {
            User? user = _userRepository.GetByEmail(email);
            return user is not null ? user.ToUserViewModel() : null;
        }

        public string login(LoginUserDTO loginUserDTO)
        {
            User? user = _userRepository.GetByEmail(loginUserDTO.Email);
            if(user is not null && user.Password == loginUserDTO.Password)
            {
                return _jwtService.GenerateToken(user);
            }

            return null;
        }

        public UserViewModel? CreateUser(CreateUserDTO createUserDTO)
        {
            return _userRepository.CreateUser(createUserDTO.ToUser())?.ToUserViewModel() ;
        }

        public UserViewModel? UpdateUser(int id, UpdateUserDTO user)
        {
            User? userToUpdate = _userRepository.GetById(id);
            if (userToUpdate is not null)
            {
                userToUpdate.Email = user.Email;
                userToUpdate.Street = user.Street;
                userToUpdate.StreetNbr = user.StreetNbr;
                userToUpdate.StreetBox = user.StreetBox;
                userToUpdate.ZipCode = user.ZipCode;
                userToUpdate.City = user.City;
                userToUpdate.Country = user.Country;
                userToUpdate.Lastname = user.Lastname;
                userToUpdate.Firstname = user.Firstname;
                userToUpdate.Phone = user.Phone;

                return _userRepository.UpdateUser(userToUpdate).ToUserViewModel();
            }
            return null;
        }

        public UserViewModel UpdatePwd(int id, UpdateUserPwdDTO updateUserPwdDTO)
        {
            User? userToUpdate = _userRepository.GetById(id);
            if (userToUpdate is not null && userToUpdate.Password == updateUserPwdDTO.Password)
            {
                userToUpdate.Password = updateUserPwdDTO.NewPassword;

                return _userRepository.UpdateUser(userToUpdate).ToUserViewModel();
            }
            return null;
        }

        public UserViewModel UpdateRole(int id, UpdateUserRoleDTO updateUserRoleDTO)
        {
            User? userToUpdate = _userRepository.GetById(id);
            if (userToUpdate is not null && Enum.IsDefined(typeof(Roles), updateUserRoleDTO.Role))
            {
                userToUpdate.Role = updateUserRoleDTO.Role;

                return _userRepository.UpdateUser(userToUpdate).ToUserViewModel();
            }
            return null;
        }

        public bool DeleteUser(int id)
        {
            User? userToUpdate = _userRepository.GetById(id);
            if (userToUpdate is not null)
            {

                return _userRepository.DeleteUser(userToUpdate);
            }
            return false;
        }


    }
}
