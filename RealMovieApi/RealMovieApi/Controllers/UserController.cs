using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealMovieContext.Models;

// [Authorize(Roles = "Administrator")]
namespace RealMovieApi.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {       
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {           
            _userManager = userManager;
            _roleManager = roleManager;
        }

       
        [HttpGet]
        public async Task<IActionResult> GetUserAsync()
        {
            var users = _userManager.Users.ToArray();
            foreach (var user in users)
            {
                user.Roles = await _userManager.GetRolesAsync(user);

            }
            return Ok(users);
        }

         
        [HttpPost]
        public async Task<IActionResult> PostUserAsync([FromBody]ApplicationUser user, [FromHeader]string password, [FromHeader]string roleId)
        {
            var result = await _userManager.CreateAsync(user, password);

            if (result.Succeeded)
            {
                var currentUser = await _userManager.FindByEmailAsync(user.Email);
                var role = await _roleManager.FindByIdAsync(roleId);
                var roleresult = await _userManager.AddToRoleAsync(currentUser, role.Name);
            }
            return Ok(result);
        }

      
        [HttpPut]
        public async Task<IActionResult> PutUserAsync([FromBody]ApplicationUser user)
        {
            var response = await _userManager.UpdateAsync(user);
            return Ok(response);
        }

       
        [HttpDelete]
        public async Task<IActionResult> DeleteUserAsync([FromBody]ApplicationUser user)
        {
            var response = await _userManager.DeleteAsync(user);
            return Ok(response);
        }


    }
}