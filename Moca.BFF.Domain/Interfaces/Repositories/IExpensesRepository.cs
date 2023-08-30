using Moca.BFF.Domain.Models.Requests.Expenses;
using Moca.BFF.Domain.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moca.BFF.Domain.Interfaces.Repositories
{
    public interface IExpensesRepository
    {
        Task<List<PostInstallmentExpensesResponse>> PostInstallmentExpenses(PostInstallmentExpensesRequest request);
    }
}
