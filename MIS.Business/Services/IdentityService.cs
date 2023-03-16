using Microsoft.Extensions.Logging;
using MIS.Business.Interfaces;

namespace MIS.Business.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly ILogger<IdentityService> _logger;

        public IdentityService(ILogger<IdentityService> logger)
        {
            _logger = logger;
        }
    }
}
