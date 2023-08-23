using Moca.BFF.Domain.Models.Requests.User;
using Moca.BFF.Domain.Models.Responses;

namespace Moca.BFF.Domain.Interfaces.Services
{
    public interface IAuthenticationService
    {
        Task<AuthUserResponse> Authenticate(AuthUserRequest request);
    }
}
