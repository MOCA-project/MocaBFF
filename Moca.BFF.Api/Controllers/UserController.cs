using Microsoft.AspNetCore.Mvc;
using Moca.BFF.Api.Controllers.Helper;
using Moca.BFF.Domain.Interfaces.Services;
using Moca.BFF.Domain.Models.Requests.User;

namespace Moca.BFF.Api.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        #region swagger doc

        /// <summary>
        /// Realiza login
        /// </summary>
        /// <response code="200">Token do usuário</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [HttpGet("login")]
        public async Task<IActionResult> Login([FromQuery]AuthUserRequest request)
        {
            var result = _userService.Login(request);
            return Ok();
        }
    }
}
