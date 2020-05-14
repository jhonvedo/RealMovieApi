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
       
        public UserController(UserManager<ApplicationUser> userManager)
        {           
            _userManager = userManager;          
        }

       
        [HttpGet]
        public IActionResult GetUser()
        {
            var users = _userManager.Users;           
            return Ok(users);
        }

         
        [HttpPost]
        public async Task<IActionResult> PostUserAsync([FromBody]ApplicationUser user, [FromHeader]string password)
        {
            var result = await _userManager.CreateAsync(user, password);
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