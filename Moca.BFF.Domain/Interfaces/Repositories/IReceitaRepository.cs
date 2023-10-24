using Moca.BFF.Domain.Models.Requests.Receitas;
using Moca.BFF.Domain.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moca.BFF.Domain.Interfaces.Repositories
{
    public interface IReceitaRepository
    {
        Task<ReceitaResponse> PatchReceita(int idReceita, PatchReceitaRequest request);
        Task<ReceitaResponse> PostReceita(ReceitaRequest request);
        Task<List<ReceitaResponse>> PostReceitaFixa(ReceitaRequest request);
    }
}
