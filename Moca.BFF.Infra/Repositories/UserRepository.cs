using Moca.BFF.Domain.Interfaces.Repositories;
using Moca.BFF.Domain.Models.Requests.User;
using Moca.BFF.Domain.Models.Responses;
using Moca.BFF.External.Mappers;
using Moca.BFF.External.Models;

namespace Moca.BFF.External.Repositories
{
    public class UserRepository : BaseHttpClient, IUserRepository
    {
        protected override string ServiceName => "usuarios";

        public async Task<AuthUserResponse> GetUserByEmailAndPassword(string password, string email)
        {
            var request = new ApiLoginRequest(password, email);
            var result = await ExecutePostAsync<ApiLoginResponse>("login", request);

            return ToDomainUserMappings.LoginResponseMap(result);
        }

        public async Task RegisterUser(RegisterUserRequest request)
        {
            var result = await ExecutePostAsync<ApiRegisterUserResponse>("cadastrar", request);

            if (result is not null)
                return;
            else
                throw new Exception("Houve um erro ao realizer o cadastro");
            
        }
    }
}
