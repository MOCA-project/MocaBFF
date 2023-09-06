using Microsoft.AspNetCore.Mvc;
using Moca.BFF.Api.Controllers.Helper;
using Moca.BFF.Domain.Interfaces.Services;
using Moca.BFF.Domain.Models.Requests.Expenses;
using Moca.BFF.Domain.Models.Responses;
using System.Net;

namespace Moca.BFF.Api.Controllers
{
    [Route("api/despesas")]
    public class ExpensesControlle : BaseController
    {
        private readonly IExpensesService _expensesService;

        public ExpensesControlle(IExpensesService expensesService )
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<PostInstallmentExpensesResponse>))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [HttpPost("parcelada")]
        public async Task<IActionResult> PostInstallmentExpenses([FromBody] PostInstallmentExpensesRequest request)
        {
            var result = await _expensesService.PostInstallmentExpenses(request);
            return Ok(result);
        }

        #region swagger doc

        /// <summary>
        /// Cadastra uma despesa fixa
        /// </summary>
        /// <response code="200">Depesa cadastrada</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<PostInstallmentExpensesResponse>))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [HttpPost("fixa")]
        public async Task<IActionResult> PostFixedExpenses([FromBody] PostFixedExpensesRequest request)
        {
            var result = await _expensesService.PostFixedExpenses(request);
            return Ok(result);
        }

        #region swagger doc

        /// <summary>
        /// Cadastra uma despesa comum
        /// </summary>
        /// <response code="200">Depesa cadastrada</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<PostInstallmentExpensesResponse>))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [HttpPost]
        public async Task<IActionResult> PostComumExpense([FromBody] PostFixedExpensesRequest request)
        {
            var result = await _expensesService.PostComumExpense(request);
            return Ok(result);
        }


        #region swagger doc

        /// <summary>
        /// Remove uma despesa
        /// </summary>
        /// <response code="200">Depesa cadastrada</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(HttpStatusCode))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [HttpDelete("{idDespesa}")]
        public async Task<IActionResult> DeleteExpense(int idDespesa)
        {
            await _expensesService.DeleteExpense(idDespesa);
            return Ok();
        }

        #region swagger doc

        /// <summary>
        /// Edita uma despesa
        /// </summary>
        /// <response code="200">Depesa cadastrada</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(HttpStatusCode))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [HttpPatch("{idDespesa}")]
        public async Task<IActionResult> PatchExpense(int idDespesa, PatchExpenseRequest request)
        {
            var response = await _expensesService.EditExpense(idDespesa, request);
            return Ok(response);
        }

        #region swagger doc

        /// <summary>
        /// Realiza o pagamento de uma despesa
        /// </summary>
        /// <response code="200">Depesa cadastrada</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(HttpStatusCode))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [HttpPatch("pagar/{idDespesa}")]
        public async Task<IActionResult> PayExpense(int idDespesa)
        {
            await _expensesService.PayExpense(idDespesa);
            return Ok();
        }

        #region swagger doc

        /// <summary>
        /// Retorna as despesas do mês detalhadas
        /// </summary>
        /// <response code="200">Depesa cadastrada</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<GetExpensesResponse>))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [HttpGet("{idCliente}/{mes}/{ano}")]
        public async Task<IActionResult> GetExpenses(int idCliente, int mes, int ano)
        {
            var result = await _expensesService.GetExpenses(idCliente, mes, ano);
            return Ok(result);
        }
    }
}
