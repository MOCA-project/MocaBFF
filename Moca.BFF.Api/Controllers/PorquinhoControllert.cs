using Microsoft.AspNetCore.Mvc;
using Moca.BFF.Api.Controllers.Helper;
using Moca.BFF.Domain.Interfaces.Services;
using Moca.BFF.Domain.Models.Requests.Porquinho;
using Moca.BFF.Domain.Models.Responses;

namespace Moca.BFF.Api.Controllers
{

    [Route("api/porquinhos")]
    public class PorquinhoController : BaseController
    {
        private readonly IPorquinhoService _porquinhoService;

        public PorquinhoController(IPorquinhoService porquinhoService)
        {
            _porquinhoService = porquinhoService;
        }


        #region swagger doc

        /// <summary>
        /// Saca algum valor do porquinho
        /// </summary>
        /// <response code="200">Depesa cadastrada</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [HttpPut("retirarValor/{clientId}/{porquinhoId}/{withdrawValue}")]
        public async Task<IActionResult> Withdraw(int clientId, int porquinhoId, decimal withdrawValue)
        {
            await _porquinhoService.Withdraw(clientId, porquinhoId, withdrawValue);
            return Ok();
        }

        #region swagger doc

        /// <summary>
        /// Conclui um porquinho
        /// </summary>
        /// <response code="200">Depesa cadastrada</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [HttpPut("finalizarPorquinho/{clientId}/{porquinhoId}")]
        public async Task<IActionResult> Finalize(int clientId, int porquinhoId)
        {
            await _porquinhoService.FinalizePorquinho(clientId, porquinhoId);
            return Ok();
        }

        #region swagger doc

        /// <summary>
        /// Deposita valor no porquinho
        /// </summary>
        /// <response code="200">Depesa cadastrada</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<PostInstallmentExpensesResponse>))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [HttpPut("adicionarValor/{clientId}/{porquinhoId}/{value}")]
        public async Task<IActionResult> Deposit(int clientId, int porquinhoId, decimal value)
        {
            await _porquinhoService.Deposit(clientId, porquinhoId, value);
            return Ok();
        }

        #region swagger doc

        /// <summary>
        /// Cria um novo porquinho
        /// </summary>
        /// <response code="200">Depesa cadastrada</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PostPorquinhoResponse))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [HttpPost]
        public async Task<IActionResult> Create(CreatePorquinhoRequest request)
        {
            var result = await _porquinhoService.PostPorquinho(request);
            return Ok(result);
        }
    }
}
