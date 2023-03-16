using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MIS.Business.MapperProfiles;
using System.Reflection;

namespace MIS.Business.Extensions
{
    public static class ServiceProviderExtensions
    {
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg => cfg.AddProfile<MisProfile>(), Assembly.GetExecutingAssembly());
            return services;
        }

        public static IServiceCollection AddMisBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
