using Moca.BFF.Domain.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moca.BFF.Domain.Interfaces.Repositories
{
    public interface IHomeRepository
    {
        Task<HomeResponse> GetHomeAsync(int idCliente, int mes, int ano);
    }
}
