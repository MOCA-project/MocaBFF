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
        public async Task<AuthUserResponse> Login(AuthUserRequest request)
        {
            var user = await _userRepository.GetUserByEmailAndPassword(request.Senha, request.Email);
            return user;
        }

        public async Task Register(RegisterUserRequest request)
        {
            await _userRepository.RegisterUser(request);
        }
    }
}
