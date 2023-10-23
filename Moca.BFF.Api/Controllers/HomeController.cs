using Microsoft.AspNetCore.Mvc;
using Moca.BFF.Api.Controllers.Helper;
using Moca.BFF.Domain.Interfaces.Repositories;
using Moca.BFF.External.Models;

namespace Moca.BFF.Api.Controllers
{
    [Route("api/home")]
    public class HomeController : BaseController
    {
        private readonly IHomeRepository _homeRepository;
        public HomeController(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }

        #region swagger doc

        /// <summary>
        /// Retorna os dados da home
        /// </summary>
        /// <response code="200">Depesa cadastrada</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiHomeResponse))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [HttpGet("{idCliente}/{mes}/{ano}")]
        public async Task<IActionResult> Withdraw(int idCliente, int mes, int ano)
        {
            var response = await _homeRepository.GetHomeAsync(idCliente, mes, ano);
            return Ok(response);
        }
    }
}
