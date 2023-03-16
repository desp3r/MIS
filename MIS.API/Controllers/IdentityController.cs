
using Microsoft.AspNetCore.Mvc;
using MIS.API.Contracts.Requests;
using MIS.API.Contracts.Routes;
using MIS.API.Controllers.BaseController;
using MIS.API.Services;

namespace MIS.API.Controllers
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
