using Microsoft.AspNetCore.Mvc;

namespace Moca.BFF.Api.Controllers
{
    public class UserController : BaseController
    {
        #region swagger doc

        /// <summary>
        /// dasdasdsa
        /// </summary>
        /// <response code="200">Sucesso</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [HttpGet]
        public async Task<IActionResult> Obter()
        {
            return Ok();
        }
    }
}
