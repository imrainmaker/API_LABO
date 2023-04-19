using DAL.Models.DTO;
using DAL.Models.ViewModels;


namespace DAL.Models.Mapper
{
    public static class UserMapper
    {
        public static User ToUser(this CreateUserDTO createUser)
        {
            return new User
            (
                createUser.Email,
                createUser.Password,
                createUser.Street,
                createUser.StreetNbr,
                createUser.StreetBox,
                createUser.ZipCode,
                createUser.City,
                createUser.Country,
                createUser.Lastname,
                createUser.Firstname,
                createUser.Phone
            );
        }

        public static UserViewModel ToUserViewModel(this User user)
        {
            if(user is not null)
            {
                return new UserViewModel
                {
                    UserId = user.UserId,
                    Email = user.Email,
                    Street = user.Street,
                    StreetNbr = user.StreetNbr,
                    StreetBox = user.StreetBox,
                    ZipCode = user.ZipCode,
                    City = user.City,
                    Country = user.Country,
                    Lastname = user.Lastname,
                    Firstname = user.Firstname,
                    Phone = user.Phone,
                    Role = user.Role
                };
            }
            return null;

        }

        public static List<UserViewModel> ToUserViewModelList (this IEnumerable<User> user)
        {
            List<UserViewModel> userViewModelList = new List<UserViewModel>();

            foreach(User u in user)
            {
                userViewModelList.Add(u.ToUserViewModel());
            }

            return userViewModelList;
        }
    }
}
