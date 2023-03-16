using MIS.API.Services;

namespace MIS.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IIdentityService, IdentityService>();

            return services;
        }
    }
}
