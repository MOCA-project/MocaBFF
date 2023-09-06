using Moca.BFF.Api.Configurations.IoC;
using Moca.BFF.Domain.Interfaces.Repositories;
using Moca.BFF.Domain.Interfaces.Services;
using Moca.BFF.External.Repositories;
using Moca.BFF.Service;

namespace Moca.BFF.Api.Configurations.IoC
{
    public static class DependencyInjectionExtensions
    {
        public static void AddDependencyInjections(this IServiceCollection services)
        {
            //Services
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IAuthenticationService, AuthenticationService>();
            services.AddSingleton<IExpensesService, ExpensesService>();
            services.AddSingleton<IPorquinhoService, PorquinhoService>();

            //Repositories
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IExpensesRepository, ExpensesRepository>();
            services.AddSingleton<IPorquinhoRepository, PorquinhoRepository>();
        }

        public static void AddOptions(this IServiceCollection services, IConfiguration config)
        {
            services.AddOptions();
        }
    }
}
