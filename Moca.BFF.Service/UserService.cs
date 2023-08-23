using Moca.BFF.Domain.Interfaces.Repositories;
using Moca.BFF.Domain.Interfaces.Services;
using Moca.BFF.Domain.Models.Requests.User;
using Moca.BFF.Domain.Models.Responses;
using Moca.BFF.External.Models;

namespace Moca.BFF.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<GetAllUsersResponse> Login(AuthUserRequest request)
        {
            var user = await _userRepository.Login();
            return user;
        }
    }
}
