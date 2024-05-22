using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication.Defaults
{
    internal class DefaultScopeAccessValidator : IScopeAccessValidator
    {
        public Task<bool> ValidateScopeAccess(string token, string scope)
        {
            var jwtValidatedToken = new JwtSecurityTokenHandler().ReadJwtToken(token);

            var scopes = jwtValidatedToken.Claims.Where(c => c.Type == "scp");

            return Task.FromResult(scopes.Any(x => x.Value.Equals(scope, StringComparison.OrdinalIgnoreCase)));
        }
    }
}
