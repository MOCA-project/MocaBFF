using Moca.BFF.Domain.Interfaces.Repositories;
using Moca.BFF.Domain.Models.Requests.Expenses;
using Moca.BFF.Domain.Models.Responses;

namespace Moca.BFF.External.Repositories
{
    public class ExpensesRepository : BaseHttpClient, IExpensesRepository
    {
        protected override string ServiceName => "despesas";

        public async Task<PatchExpenseResponse> EditExpense(int idDespesa, PatchExpenseRequest request)
        {
            var result = await ExecutePatchAsync<PatchExpenseResponse>($"{idDespesa}", request);
            return result;
        }

        public async Task<List<GetExpensesResponse>> GetExpenses(int idCliente, int mes, int ano)
        {
            var result = await ExecuteGetAsync<List<GetExpensesResponse>>($"{idCliente}/{mes}/{ano}");
            return result;
        }

        public async Task<PayExpenseResponse> PayExpense(int idDespesa)
        {
            return await ExecutePatchAsync<PayExpenseResponse>($"pagar/{idDespesa}", null);
        }

        public async Task<PostFixedExpensesResponse> PostComumExpense(PostFixedExpensesRequest request)
        {
            var response = await ExecutePostAsync<PostFixedExpensesResponse>(string.Empty, request);
            return response;
        }

        public async Task<PostFixedExpensesResponse> PostFixedExpenses(PostFixedExpensesRequest request)
        {
            var response = await ExecutePostAsync<PostFixedExpensesResponse>("fixa", request);
            return response;
        }

        public async Task<List<PostInstallmentExpensesResponse>> PostInstallmentExpenses(PostInstallmentExpensesRequest request)
        {
            var response = await ExecutePostAsync<List<PostInstallmentExpensesResponse>>("parcelada", request);
            return response;
        }

        public async Task RemoveExpenseAsync(int idDespesa)
        {
            await ExecuteDeleteAsync(idDespesa.ToString());
        }
    }
}
