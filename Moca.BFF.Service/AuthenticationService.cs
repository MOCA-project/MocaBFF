using Microsoft.IdentityModel.Tokens;
using Moca.BFF.Domain.Interfaces.Services;
using Moca.BFF.Domain.Models.Requests.User;
using Moca.BFF.Domain.Models.Responses;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Moca.BFF.Service
{
    public class AuthenticationService : IAuthenticationService
    {
        private const string Secret = "hBvvYsTBFGnyHjuDmLfDolGqFCGWEvHZlyeHJXeamNJkpjQsOphQKTulscjZPuWB";
        private static readonly TimeSpan TokenLifeTime = TimeSpan.FromHours(12);
        private readonly IUserService _userService;

        public AuthenticationService(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<AuthUserResponse> Authenticate(AuthUserRequest request)
        {
            var user = await _userService.Login(request);

            if (user != null)
            {
                var token = GenerateJwtToken(user);
                return new AuthUserResponse
                {
                    Token = token,
                    Email = user.Email,
                    Id = user.Id,
                    IdTipoPerfil = user.IdTipoPerfil,
                    Nome = user.Nome,
                };
            }

            return null;
        }

        private string GenerateJwtToken(AuthUserResponse user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Secret);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Nome),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim("IdTipoPerfil", user.IdTipoPerfil.ToString()),
                new Claim("Id", user.Id.ToString()),
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.Add(TokenLifeTime),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
