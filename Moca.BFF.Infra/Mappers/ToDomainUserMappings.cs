using Moca.BFF.Crosscuting.Models;
using Moca.BFF.Domain.Models.Responses;
using Moca.BFF.External.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
