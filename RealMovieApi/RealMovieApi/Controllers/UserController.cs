using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealMovieApi.Models;
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
            var users = _userManager.Users.ToArray();
            return Ok(users.ToViewModelArray());
        }


        [HttpPost]
        public async Task<IActionResult> PostUserAsync([FromBody]UserViewModel user)
        {
            var result = await _userManager.CreateAsync(user.ToIdentityUser(), user.Password);
            return result.Succeeded ? Ok(result) : (IActionResult)NotFound(GetErrorMessage(result));
        }


        [HttpPut]
        public async Task<IActionResult> PutUserAsync([FromBody]UserViewModel user)
        {
            var response = await _userManager.UpdateAsync(user.ToIdentityUser());
            return response.Succeeded ? Ok(response) : (IActionResult)NotFound(GetErrorMessage(response));
        }


        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteUserAsync([FromRoute] string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if(user == null)
            {
                return NotFound();
            }
            var response = await _userManager.DeleteAsync(user);
            return response.Succeeded ? Ok(response) : (IActionResult)NotFound(GetErrorMessage(response));
        }


        private string GetErrorMessage(IdentityResult result)
        {
            string error = string.Empty;

            if (result.Errors != null)
            {
                error = string.Join(",",result.Errors.Select(x=>x.Description));
            }

            return error;

        }


    }
}