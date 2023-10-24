using Microsoft.AspNetCore.Mvc;
using Moca.BFF.Api.Controllers.Helper;
using Moca.BFF.Domain.Interfaces.Repositories;
using Moca.BFF.Domain.Models.Requests.Receitas;

namespace Moca.BFF.Api.Controllers
{
    [Route("api/receitas")]
    public class ReceitasController : BaseController
    {
        private readonly IReceitaRepository _receitasRepository;

        public ReceitasController(IReceitaRepository notificationRepository)
        {
            _receitasRepository = notificationRepository;
        }

        #region swagger doc

        /// <summary>
        /// Cadastra uma receita
        /// </summary>
        /// <response code="200">Depesa cadastrada</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [HttpPost]
        public async Task<IActionResult> PostReceita([FromBody] ReceitaRequest request)
        {    
            return Ok(await _receitasRepository.PostReceita(request));
        }

        #region swagger doc

        /// <summary>
        /// Cadastra uma receita fixa
        /// </summary>
        /// <response code="200">Depesa cadastrada</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [HttpPost("fixa")]
        public async Task<IActionResult> PostReceitaFixa([FromBody] ReceitaRequest request)
        {
            
            return Ok(await _receitasRepository.PostReceitaFixa(request));
        }

        #region swagger doc

        /// <summary>
        /// Altera uma receita
        /// </summary>
        /// <response code="200">Depesa cadastrada</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [HttpPatch("{idReceita}")]
        public async Task<IActionResult> PatchReceita(int idReceita, [FromBody] PatchReceitaRequest request)
        {

            return Ok(await _receitasRepository.PatchReceita(idReceita, request ));
        }

    }
}
