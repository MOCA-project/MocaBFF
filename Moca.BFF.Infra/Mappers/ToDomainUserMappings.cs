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
        public static GetAllUsersResponse ToDomain(List<ApiClientListResponse> response)
        {
            var domain = new GetAllUsersResponse();
            foreach (var item in response)
            {
                domain.response.Add(new GetAllUsersResponseContent
                {
                    Email = item.Email,
                });
            }
            return domain;
        }
    }
}
