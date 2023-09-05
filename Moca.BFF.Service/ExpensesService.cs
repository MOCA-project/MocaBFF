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

        public async Task DeleteExpense(int idDespesa)
        {
            await _expensesRepository.RemoveExpenseAsync(idDespesa);
        }

        public async Task<PatchExpenseResponse> EditExpense(int idDespesa, PatchExpenseRequest request)
        {
            var result = await _expensesRepository.EditExpense(idDespesa, request);
            return result;
        }

        public async Task<List<GetExpensesResponse>> GetExpenses(int idCliente, int mes, int ano)
        {
            var result = await _expensesRepository.GetExpenses(idCliente, mes, ano);
            return result;
        }

        public async Task<PayExpenseResponse> PayExpense(int idDespesa)
        {
            return await _expensesRepository.PayExpense(idDespesa);
        }

        public async Task<PostFixedExpensesResponse> PostComumExpense(PostFixedExpensesRequest request)
        {
            var result = await _expensesRepository.PostComumExpense(request);
            return result;
        }

        public async Task<PostFixedExpensesResponse> PostFixedExpenses(PostFixedExpensesRequest request)
        {
            var result = await _expensesRepository.PostFixedExpenses(request);
            return result;
        }

        public async Task<List<PostInstallmentExpensesResponse>> PostInstallmentExpenses(PostInstallmentExpensesRequest request)
        {
            var result = await _expensesRepository.PostInstallmentExpenses(request);
            return result;
        }
    }
}
