using Moca.BFF.Domain.Interfaces.Repositories;
using Moca.BFF.Domain.Models.Requests.Expenses;
using Moca.BFF.Domain.Models.Requests.User;
using Moca.BFF.Domain.Models.Responses;

namespace Moca.BFF.Domain.Interfaces.Services
{
    public interface IExpensesService
    {
        Task<List<PostInstallmentExpensesResponse>> PostInstallmentExpenses(PostInstallmentExpensesRequest request);
    }
}
