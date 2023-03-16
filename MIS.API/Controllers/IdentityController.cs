
using Microsoft.AspNetCore.Mvc;
using MIS.Api.Controllers.Base;
using MIS.Business.Interfaces;

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
