using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealMovieApi.Models;
using RealMovieApi.Utils;
using RealMovieContext;
using RealMovieContext.Models;

namespace RealMovieApi.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly IdentityContext _context;

        public IdentityController(IdentityContext context)
        {
            _context = context;
        }

        [Route("Role")]
        [HttpGet]
        public IActionResult GetRole()
        {
            return Ok(_context.Roles);
        }

        [Route("User")]
        [HttpPost]
        public IActionResult PostUser([FromBody]User user)
        {
            var existingUser= _context.Users.FirstOrDefault(x => x.UserName.Equals(user.UserName));

            if (existingUser != null)
            {
                return Conflict(new { Message="User alredy exist"} );
            }
            user.Password = EncryptService.Encrypt(user.Password);
            _ = _context.Users.Add(user);
            _= _context.SaveChanges();
            user.Password = null;

            return Ok(user);
        }

        [Route("Login")]
        [HttpPost]
        public IActionResult PostLogin([FromBody]UserViewModel user)
        {
            user.Password = EncryptService.Encrypt(user.Password);
            var existingUser = _context.Users.FirstOrDefault(x => x.UserName.Equals(user.UserName) && x.Password.Equals(user.Password));

            if (existingUser == null)
            {
                return Unauthorized();
            }           
            existingUser.Password = null;

            return Ok(existingUser);
        }



    }
}