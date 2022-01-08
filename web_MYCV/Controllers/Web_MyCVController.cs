using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_MYCV.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Web_MyCVController : ControllerBase
    {
        
        private readonly ILogger<Web_MyCVController> _logger;

        public Web_MyCVController(ILogger<Web_MyCVController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Web_MyCV[] Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Web_MyCV
            {
                Date = DateTime.Now.AddDays(index),
               
              
            })
            .ToArray();
        }
    }
}
