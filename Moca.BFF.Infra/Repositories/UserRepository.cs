using Moca.BFF.Domain.Interfaces.Repositories;
using Moca.BFF.Domain.Models.Responses;
using Moca.BFF.External.Models;

namespace Moca.BFF.External.Repositories
{
    public class UserRepository : BaseHttpClient, IUserRepository
    {
        protected override string ServiceName => "usuarios";


        public async Task<AuthUserResponse> Login()
        {
            var a = await ExecuteGetAsync<List<User>>("");

            return new AuthUserResponse();
        }
    }
}
