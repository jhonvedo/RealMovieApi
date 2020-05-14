using RealMovieApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMovieContext.Models
{
    public static class IdentityModelExtends
    {

        public  static UserViewModel ToViewModel(this ApplicationUser user)
        {
            return new UserViewModel()
            {
                Id = user.Id,
                Email=user.Email,
                FirstName=user.FirstName,
                LastName = user.LastName,
                IsAdmin=user.IsAdmin,
                UserName=user.UserName
            };
        }
        
        public static List<UserViewModel> ToViewModelArray(this ApplicationUser[] user)
        {
            List<UserViewModel> list = new List<UserViewModel>();
            foreach (var item in user)
            {
                list.Add(item.ToViewModel());
            }
            return list;
        }

        public static ApplicationUser UpdateFromViewModel(this ApplicationUser user, UserViewModel viewModel)
        {
            user.FirstName = viewModel.FirstName;
            user.LastName = viewModel.LastName;
            user.IsAdmin = viewModel.IsAdmin;
            user.Email = viewModel.Email;
            user.UserName = viewModel.UserName;


            return user;
        }

        

    }
}
