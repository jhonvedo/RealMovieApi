using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
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
            var data = _showService.GetShows();
            return Ok(data);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute]int id)
        {
            var data = _showService.GetShow(id,true,true);
            return Ok(data);
        }
    }
}