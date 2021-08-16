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

namespace ExpanseManager.Repositories
{
    public class IdentityRepo : IIdentityRepo
    {
        private readonly IUserAuthRepository _userAuthRepository;

        public IdentityRepo(IUserAuthRepository userAuthRepository)
        {
            _userAuthRepository = userAuthRepository;
        }
        public string Authenticate(string name, string password)
        {
            var user = _userAuthRepository.GetByNameAndPassword(name, password);
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJVc2VybmFtZSI6Ildva2VyIiwiZXhwIjoxNjI4NzUzNTc5LCJpYXQiOjE2Mjg1ODA3Nzl9.-yp-7NkKHGtEdr8rMyrAwMyQszaktGCIHLNAGI8jBEo");

            var serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            var claims = new List<Claim>() {
                            new Claim(ClaimTypes.Name, user.Name),
            };
            var identity = new ClaimsIdentity(claims);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = identity,
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
