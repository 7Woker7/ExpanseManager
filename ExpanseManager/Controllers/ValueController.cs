using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExpanseManager.Controllers
{
    [Route("api/value")]
    public class ValueController : Controller
    {
        //[Authorize]
        public IActionResult Get()
        {
            var list = new string[] { "value1", "value2" };
            return Ok(list);
        }
    }
}
