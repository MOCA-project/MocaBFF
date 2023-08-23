using Moca.BFF.Domain.Models.Responses;
using Moca.BFF.External.Models;

namespace Moca.BFF.External.Mappers
{
    internal static class ToDomainUserMappings
    {
        public static AuthUserResponse LoginResponseMap(ApiLoginResponse response)
        {

            var domain = new AuthUserResponse()
            {
                Email = response.Email,
                Id = response.Id,
                IdTipoPerfil = response.IdTipoPerfil,
                Nome = response.Nome
            };

            return domain;

        }
    }
}
