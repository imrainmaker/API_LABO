using BLL.Interfaces;
using DAL.Models;
using DAL.Models.DTO;
using DAL.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

////////////////////////////
///
/// FAIRE LES AUTHORIZE !

namespace API_LABO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public ActionResult<List<UserViewModel>> Get()
        {
            return Ok(_userService.GetAll());
        }



        [HttpGet("{id:int}")]
        public ActionResult<UserViewModel?> GetById(int id)
        {
            if (ModelState.IsValid)
            {
                UserViewModel? userVM = _userService.GetById(id);
                return userVM is not null ? Ok(userVM) : BadRequest();
            }

            return BadRequest();
        }



        [HttpGet("{Email}")]
        public ActionResult<UserViewModel?> GetByEmail(string Email)
        {
            if (ModelState.IsValid)
            {
                UserViewModel? userVM = _userService.GetByEmail(Email);
                return userVM is not null ? Ok(userVM) : BadRequest();
            }

            return BadRequest();
        }



        [HttpPost("Login")]
        public ActionResult<string> Login(LoginUserDTO loginDTO)
        {

            if (ModelState.IsValid)
            {
                string? userVM = _userService.login(loginDTO);
                return userVM is not null ? Ok(userVM) : BadRequest();
            }

            return BadRequest();
        }


        [HttpPost]
        public ActionResult<UserViewModel?> CreateUser(CreateUserDTO createUserDTO)
        {

            if (ModelState.IsValid)
            {
                UserViewModel? userVM = _userService.CreateUser(createUserDTO);
                return userVM is not null ? Ok(userVM) : BadRequest();
            }

            return BadRequest();
        }


        [HttpPut("{id}")]
        public ActionResult<UserViewModel?> UpdateUser(int id, UpdateUserDTO updateUserDTO) 
        {
 
            if (ModelState.IsValid)
            {
                UserViewModel? userVM = _userService.UpdateUser(id, updateUserDTO);
                return userVM is not null ? Ok(userVM) : BadRequest();
            }

            return BadRequest();
        }


        [HttpPatch("{id}")]
        public ActionResult<UserViewModel?> UpdatePwd(int id, UpdateUserPwdDTO updateUserPwdDTO)
        {

            if (ModelState.IsValid)
            {
                UserViewModel? userVM = _userService.UpdatePwd(id, updateUserPwdDTO);
                return userVM is not null ? Ok(userVM) : BadRequest();
            }

            return BadRequest();
        }

        [HttpPatch("Role/{id}")]
        public ActionResult<UserViewModel?> UpdateRole(int id, UpdateUserRoleDTO updateUserRoleDTO)
        {

            if (ModelState.IsValid)
            {
                UserViewModel? userVM = _userService.UpdateRole(id, updateUserRoleDTO);
                return userVM is not null ? Ok(userVM) : BadRequest();
            }

            return BadRequest();
        }


        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteUser(int id)
        {
            if (ModelState.IsValid)
            {
                bool userVM = _userService.DeleteUser(id);
                return userVM is true ? Ok(userVM) : BadRequest();
            }

            return BadRequest();
        }
    }
}
