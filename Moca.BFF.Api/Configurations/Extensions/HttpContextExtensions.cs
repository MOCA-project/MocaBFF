using Moca.BFF.Api.Configurations.Security;

namespace Moca.BFF.Api.Configurations.Extensions
{
    public static class HttpContextExtensions
    {
        public static UserClaims ObterClaimsUsuario(this HttpContext context)
            => new(context?.User?.Identity);
    }
}
