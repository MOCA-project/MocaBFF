using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Moca.BFF.Api.Controllers.Helper
{
    // [Authorize]
    [AllowAnonymous]
    [ApiController]
    public class BaseController : ControllerBase
    {

    }
}
