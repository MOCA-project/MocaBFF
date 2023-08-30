using Moca.BFF.Domain.Interfaces.Repositories;
using Moca.BFF.Domain.Models.Requests.Expenses;
using Moca.BFF.Domain.Models.Responses;

namespace Moca.BFF.External.Repositories
{
    public class ExpensesRepository : BaseHttpClient,  IExpensesRepository
    {
        protected override string ServiceName => "despesas";

        public async Task<List<PostInstallmentExpensesResponse>> PostInstallmentExpenses(PostInstallmentExpensesRequest request)
        {
            var response = await ExecutePostAsync<List<PostInstallmentExpensesResponse>>("/parcelada", request);
            return response;
        }
    }
}
