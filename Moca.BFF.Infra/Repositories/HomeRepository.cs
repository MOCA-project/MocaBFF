using Moca.BFF.Domain.Interfaces.Repositories;
using Moca.BFF.Domain.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moca.BFF.External.Repositories
{
    public class HomeRepository : BaseHttpClient, IHomeRepository
    {
        protected override string ServiceName => "home";

        public async Task<HomeResponse> GetHomeAsync(int idCliente, int mes, int ano)
        {
            return await ExecuteGetAsync<HomeResponse>($"{idCliente}/{mes}/{ano}");
        }
    }
}
