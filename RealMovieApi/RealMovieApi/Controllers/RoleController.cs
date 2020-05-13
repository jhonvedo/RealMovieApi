using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// [Authorize(Roles = "Administrator")]
namespace RealMovieApi.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public RoleController(RoleManager<IdentityRole> roleManager)
        {           
            _roleManager = roleManager;
        }


      
        [HttpGet]
        public IActionResult GetRole()
        {
            var response = _roleManager.Roles;
            return Ok(response);
        }
          
        [HttpPost]
        public async Task<IActionResult> PostRoleAsync([FromBody]IdentityRole role)
        {
            var response = await _roleManager.CreateAsync(role);
            return Ok(response);
        }
           
        [HttpPut]
        public async Task<IActionResult> PutRoleAsync([FromBody]IdentityRole role)
        {
            var response = await _roleManager.UpdateAsync(role);
            return Ok(response);
        }
        
        [HttpDelete]
        public async Task<IActionResult> DeleteRoleAsync([FromBody]IdentityRole role)
        {
            var response = await _roleManager.DeleteAsync(role);
            return Ok(response);
        }
    }
}