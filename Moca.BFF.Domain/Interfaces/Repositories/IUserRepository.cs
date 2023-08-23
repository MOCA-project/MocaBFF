using Moca.BFF.Domain.Models.Requests.User;
using Moca.BFF.Domain.Models.Responses;

namespace Moca.BFF.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<AuthUserResponse> GetUserByEmailAndPassword(string password, string email);
        Task RegisterUser(RegisterUserRequest request);
    }
}
