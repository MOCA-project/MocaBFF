using Moca.BFF.Api.Configurations.IoC;

namespace Moca.BFF.Api.Configurations.IoC
{
    public static class DependencyInjectionExtensions
    {
        public static void AddDependencyInjections(this IServiceCollection services)
        {
            //Services

            //Repositories
        }

        public static void AddOptions(this IServiceCollection services, IConfiguration config)
        {
            services.AddOptions();
        }
    }
}
