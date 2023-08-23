using Moca.BFF.Crosscuting.Models;
using Moca.BFF.Domain.Interfaces.Repositories;
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
    }
}
