using Microsoft.AspNetCore.Mvc;
using Moca.BFF.Api.Configurations.Security;

namespace Moca.BFF.Api.Configurations.Extensions
{
    public static class ControllerBaseExtensions
    {

        public static UserClaims ObterClaimsUsuario(this ControllerBase controller)
            => controller.HttpContext.ObterClaimsUsuario();
    }
}
