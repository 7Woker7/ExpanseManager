using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpanseManager.Controllers
{
    [Route("api/value")]
    public class ValueController : Controller
    {
        public IActionResult Get()
        {
            var list = new string[] { "value1", "value2" };
            return Ok(list);
        }
    }
}
