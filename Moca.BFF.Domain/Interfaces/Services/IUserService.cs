using Moca.BFF.Domain.Models.Requests.User;
using Moca.BFF.Domain.Models.Responses;

namespace Moca.BFF.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<AuthUserResponse> Login(AuthUserRequest request);
    }
}
