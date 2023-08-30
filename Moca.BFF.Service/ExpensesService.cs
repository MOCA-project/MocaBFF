using Moca.BFF.Domain.Interfaces.Services;
using Moca.BFF.Domain.Models.Requests.Expenses;
using Moca.BFF.Domain.Models.Requests.User;
using Moca.BFF.Domain.Models.Responses;

namespace Moca.BFF.Domain.Interfaces.Repositories
{
    public class ExpensesService : IExpensesService
    {

        private readonly IExpensesRepository _expensesRepository;

        public ExpensesService(IExpensesRepository expensesRepository)
        {
            _expensesRepository = expensesRepository;
        }

        public async Task<List<PostInstallmentExpensesResponse>> PostInstallmentExpenses(PostInstallmentExpensesRequest request)
        {
            var result = await _expensesRepository.PostInstallmentExpenses(request);
            return result;
        }
    }
}
