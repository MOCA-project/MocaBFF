using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Moca.BFF.Api.Controllers.Helper;
using Moca.BFF.Domain.Interfaces.Services;
using Moca.BFF.Domain.Models.Requests.User;

namespace Moca.BFF.Api.Controllers
{
    [Route("usuarios")]

    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IAuthenticationService _authenticationService;

        public UserController(IUserService userService, 
            IAuthenticationService authenticationService)
        {
            _userService = userService;
            _authenticationService = authenticationService;
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

        [AllowAnonymous]
        [HttpGet("login")]
        public async Task<IActionResult> Login([FromQuery]AuthUserRequest request)
        {
            var result = await _authenticationService.Authenticate(request);
            return Ok(result);
        }

        #region swagger doc

        /// <summary>
        /// Realiza o cadastro
        /// </summary>
        /// <response code="200">Token do usuário</response>
        /// <response code="403">Se você não tiver permissão para realizar esta ação</response>
        /// <response code="500">Erro ao executar solicitação</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(void))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]

        #endregion swagger doc

        [AllowAnonymous]
        [HttpPost("cadastrar")]
        public async Task<IActionResult> Resigster([FromBody] RegisterUserRequest request)
        {
            await _userService.Register(request);
            return Created("", null);
        }
    }
}
