﻿using Moca.BFF.Domain.Models.Requests.Expenses;
using Moca.BFF.Domain.Models.Responses;

namespace Moca.BFF.Domain.Interfaces.Repositories
{
    public interface IExpensesRepository
    {
        Task<PatchExpenseResponse> EditExpense(int idDespesa, PatchExpenseRequest request);
        Task<List<GetExpensesResponse>> GetExpenses(int idCliente, int mes, int ano);
        Task<PayExpenseResponse> PayExpense(int idDespesa);
        Task<PostFixedExpensesResponse> PostComumExpense(PostFixedExpensesRequest request);
        Task<PostFixedExpensesResponse> PostFixedExpenses(PostFixedExpensesRequest request);
        Task<List<PostInstallmentExpensesResponse>> PostInstallmentExpenses(PostInstallmentExpensesRequest request);
        Task RemoveExpenseAsync(int idDespesa);
    }
}
