using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PolyFood.Business.Service.IService
{
    public interface IJwtService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
        bool IsTokenExpired(string token);
        string? ValidateToken(string token);
        string ExtractTokenFromHeader(string authorizationHeader);
    }
}
