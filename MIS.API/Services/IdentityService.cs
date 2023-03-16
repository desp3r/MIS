using MIS.API.Contracts.Requests;
using MIS.API.Contracts.Responses;

namespace MIS.API.Services
{
    public interface IIdentityService
    {
        Task<RegisterUserResponse> RegisterUser(RegisterUserRequest request);
    }
    
    public class IdentityService : IIdentityService
    {
        private readonly ILogger<IdentityService> _logger;

        public IdentityService(ILogger<IdentityService> logger)
        {
            _logger = logger;
        }

        public async Task<RegisterUserResponse> RegisterUser(RegisterUserRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
