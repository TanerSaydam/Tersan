using CleanArchitecture.Application.Abstractions;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Text;

namespace CleanArchitecture.Infrastructure.Authentication;
public sealed class JwtService : IJwtService
{
    public string CreateToken(string userName)
    {
        List<Claim> claims = new List<Claim>()
        {
            new Claim("UserName", userName),
        };

        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("my secret key my secret key my secret key my secret key my secret key my secret key my secret key my secret key my secret key my secret key my secret key my secret key my secret key "));

        JwtSecurityToken securityToken = new(
            issuer: "Taner Saydam",
            audience: "Herkes",
            claims: claims,
            notBefore: DateTime.Now,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512));

        JwtSecurityTokenHandler handler = new();

        string token = handler.WriteToken(securityToken);

        return token;
    }
}
