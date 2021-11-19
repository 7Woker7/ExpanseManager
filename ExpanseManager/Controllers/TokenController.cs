using ExpanseManager.DTO;
using ExpanseManager.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AuthWebApp.Controllers
{
    [Route("api/token")]
    public class TokenController : Controller
    {
        private readonly IIdentityRepo _identityRepo;
        private readonly IHashing _hashing;
        private readonly ILogger<TokenController> _logger;
        public TokenController(IIdentityRepo identityRepo, IHashing hashing, ILogger<TokenController> logger)
        {
            _identityRepo = identityRepo;
            _hashing = hashing;
            _logger = logger;
        }
       
        [HttpPost]
        [Produces("application/json")]
        public IActionResult Post([FromBody] LoginDto userParam)
        {
            userParam.Password = _hashing.GetHash(userParam.Password);
            var token = _identityRepo.Authenticate(userParam.Name, userParam.Password);

            string user = userParam.Name;
            _logger.LogInformation("User '{user}' just signed in ", user );

            var result = new { token = token };
            return Ok(result);
        }


       
    }
}
