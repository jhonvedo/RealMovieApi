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
    [Route("api/[controller]")]
    [ApiController]
    public class SignInController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public SignInController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;           
        }
        
        [HttpPost]
        public async Task<IActionResult> PostLoginAsync([FromQuery]string user, [FromQuery]string password)
        {
            var result = await _signInManager.PasswordSignInAsync(user, password, true, false);            
            return Ok(result);
        }

    }
}