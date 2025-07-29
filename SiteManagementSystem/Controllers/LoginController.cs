using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SiteManagementSystem.Models;
using System.Text;

namespace SiteManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public LoginController(IConfiguration configuration) 
        {
            _configuration = configuration;
        }
        [HttpPost]
        public IActionResult Login(UserDto user)
        {
            var jwtKey = _configuration["Jwt:Key"] ?? "ThisIsASecureSecretKeyForJWTTokenGeneration";
            var issuer = _configuration["Jwt:Issuer"] ?? "MyAuthServer";
            if (user.Username == "string" && user.Password == "string")
            {
                var token = GenerateJwtToken(user.Username, jwtKey, issuer);
                return Ok(new { token });
            }

            return Unauthorized();
        }

        string GenerateJwtToken(string username, string key, string issuer)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new System.IdentityModel.Tokens.Jwt.JwtSecurityToken(
                issuer: issuer,
                audience: null,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials,
                claims: new[] {
            new System.Security.Claims.Claim("sub", username),
            new System.Security.Claims.Claim("role", "Admin")
                }
            );

            return new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
