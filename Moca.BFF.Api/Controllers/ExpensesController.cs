using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Moca.BFF.Api.Controllers.Helper;
using Moca.BFF.Domain.Interfaces.Services;
using Moca.BFF.Domain.Models.Requests.Expenses;
using Moca.BFF.Domain.Models.Requests.User;

namespace Moca.BFF.Api.Controllers
{
    public class ExpensesController : BaseController
    {
        private readonly IExpensesService _expensesService;

        public ExpensesController(IExpensesService expensesService )
        {
            _expensesService = expensesService;
        }

        #region swagger doc

        /// <summary>
        /// Cadastra uma despesa parcelada
        /// </summary>
        /// <response code="200">Depesa cadastrada</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [AllowAnonymous]
        [HttpPost("parcelada")]
        public async Task<IActionResult> PostInstallmentExpenses([FromBody] PostInstallmentExpensesRequest request)
        {
            var result = await _expensesService.PostInstallmentExpenses(request);
            return Ok(result);
        }
    }
}
