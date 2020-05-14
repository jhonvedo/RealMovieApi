using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using MovieStore.Models;
using MovieStore.Services;

namespace RealMovieApi.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class ShowController : ControllerBase
    {
        private readonly ShowService _showService;
        private readonly IMemoryCache _cache;
        private readonly string _cacheKey = "ShowsList";
        public ShowController(ShowService showService, IMemoryCache cache)
        {
            _showService = showService;
            _cache = cache;
        }
        
        [HttpGet]
        public IActionResult Get()        
        {
            List<Show> data;        
            if (!_cache.TryGetValue(_cacheKey,out data))
            {
                if(data == null)
                {
                    data = _showService.GetShows();                   
                }
                var cacheEntryOptions = new MemoryCacheEntryOptions() 
                    .SetSlidingExpiration(TimeSpan.FromMinutes(3));
                _ = _cache.Set(_cacheKey, data, cacheEntryOptions);
            }

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