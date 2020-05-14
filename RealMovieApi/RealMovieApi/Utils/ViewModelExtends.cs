using RealMovieContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMovieApi.Models
{
    public static class ViewModelExtends
    {
        public static ApplicationUser ToIdentityUser(this UserViewModel user)
        {
            return new ApplicationUser()
            {              
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                IsAdmin = user.IsAdmin,
                UserName = user.UserName
            };
        }

       
    }
}
