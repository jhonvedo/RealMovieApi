using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Services;

namespace RealMovieApi.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class ShowController : ControllerBase
    {
        private readonly ShowService _showService;
        public ShowController(ShowService showService)
        {
            _showService = showService;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_showService.GetShows());
        }
    }
}