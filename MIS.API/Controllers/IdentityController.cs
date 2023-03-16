
using Microsoft.AspNetCore.Mvc;
using Mis.Api.Contracts.Requests;
using Mis.Api.Contracts.Routes;
using Mis.Api.Controllers.BaseController;
using Mis.Api.Services;

namespace Mis.Api.Controllers
{
    public class IdentityController : BaseApiController
    {
        private readonly ILogger<IdentityController> _logger;
        private readonly IIdentityService _identityService;

        public IdentityController(
            ILogger<IdentityController> logger, 
            IIdentityService identityService)
        {
            _logger = logger;
            _identityService = identityService;
        }

        [HttpPost(ApiRoutes.Identity.Register)]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterUserRequest request)
        {
            var registrationResult = await _identityService.RegisterUser(request);
            return Ok();
        }

    }
}
