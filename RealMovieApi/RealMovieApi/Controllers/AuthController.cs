using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealMovieContext.Models;

namespace RealMovieApi.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public AuthController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;           
        }
        
        [HttpPost]     
        [Route("signin")]
        public async Task<IActionResult> PostLoginAsync([FromHeader]string username, [FromHeader]string password)
        {
            var result = await _signInManager.PasswordSignInAsync(username, password, true, false);
            if (!result.Succeeded)
            {
                return Unauthorized();
            }

            var identityUser = await _userManager.FindByNameAsync(username);
            return Ok(identityUser);
        }

     

    }
}