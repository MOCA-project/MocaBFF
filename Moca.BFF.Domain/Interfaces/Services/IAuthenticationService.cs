using Moca.BFF.Domain.Models.Requests.User;
using Moca.BFF.Domain.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moca.BFF.Domain.Interfaces.Services
{
    public interface IAuthenticationService
    {
        Task<AuthUserResponse> Authenticate(AuthUserRequest request);
    }
}
