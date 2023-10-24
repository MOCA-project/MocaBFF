using Moca.BFF.Domain.Interfaces.Repositories;
using Moca.BFF.Domain.Models.Requests.Receitas;
using Moca.BFF.Domain.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moca.BFF.External.Repositories
{
    public class ReceitaRepository : BaseHttpClient, IReceitaRepository
    {
        protected override string ServiceName => "receitas";

        public async Task<ReceitaResponse> PatchReceita(int idReceita, PatchReceitaRequest request)
        {
            return await ExecutePatchAsync<ReceitaResponse>($"{idReceita}", request);
        }

        public async Task<ReceitaResponse> PostReceita(ReceitaRequest request)
        {
            return await ExecutePostAsync<ReceitaResponse>(string.Empty, request);
        }

        public async Task<List<ReceitaResponse>> PostReceitaFixa(ReceitaRequest request)
        {
            return await ExecutePostAsync<List<ReceitaResponse>>("fixa", request);
        }
    }
}
