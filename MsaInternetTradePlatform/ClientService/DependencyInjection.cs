using ClientService.Repositories;
using ClientService.Services;

namespace ClientService
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddClientServiceApplication(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddServices();
            return services;
        }
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IClientRepository, ClientRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IClientManagementService, ClientManagementService>();
            return services;
        }
    }
}
