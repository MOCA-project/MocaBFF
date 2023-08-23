using System.Security.Claims;
using System.Security.Principal;

namespace Moca.BFF.Api.Configurations.Security
{
    public class UserClaims
    {
        public int Id { get; set; }

        public UserClaims(IIdentity userIdentity)
        {
            var identity = userIdentity as ClaimsIdentity;

            _ = int.TryParse(identity.FindFirst(nameof(Id))?.Value, out int userId);
            this.Id = userId;
        }
    }
}
