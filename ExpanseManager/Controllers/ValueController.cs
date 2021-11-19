using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace ExpanseManager.Controllers
{
    [Route("api/value")]
    public class ValueController : Controller
    {
        private readonly ILogger<ValueController> _logger;
        public ValueController(ILogger<ValueController> logger)
        {
            _logger = logger;
        }

        //[Authorize]
        public IActionResult Get()
        {
            var list = new string[] { "value1", "value2" };
            _logger.LogInformation("The value was asked");
            return Ok(list);
            
    }
    }
}
