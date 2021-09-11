using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Text;
using Domain.Settings;
using System.Threading.Tasks;
using Sm.Pedidos.Server.Services;
using Microsoft.Extensions.Options;

namespace Sm.Pedidos.Services
{
    public class TokenService : ITokenService
    {
        private AppSettings _appSettings;
        private UserManager<IdentityUser> _userMaganer;

        public TokenService(IOptions<AppSettings> appSettings, UserManager<IdentityUser> userMaganer)
        {
            _appSettings = appSettings.Value;
            _userMaganer = userMaganer;
        }

        public async Task<string> GenerateTokenAsync(string email)
        {
            var user = await _userMaganer.FindByEmailAsync(email);
            var Secret = _appSettings.SecretJwt;

            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Secret));
            var expiraEm = DateTime.UtcNow.AddHours(_appSettings.ExpirationHours);

            ClaimsIdentity claimsPrincipal = new ClaimsIdentity(new Claim[]
            {
                 new Claim(nameof(user.UserName), user.UserName)
            });

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = _appSettings.Issuer,
                Audience = _appSettings.ValidOn[0],
                Expires = DateTime.UtcNow.AddHours(_appSettings.ExpirationHours),
                Subject = claimsPrincipal,
                SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            return tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));
        }

        //public UserAuthenticated GenerateUserAutenticated(IdentityUser user, string Key)
        //{
        //    return new UserAuthenticated()
        //    {
        //        Token = GenerateToken(user, Key),

        //        Expire = DateTime.UtcNow.AddDays(1).Date
        //    };
        //}
    }
}
