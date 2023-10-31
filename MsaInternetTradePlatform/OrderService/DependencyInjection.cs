using OrderService.Repositories;
using OrderService.Services;

namespace OrderService
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddOrderServiceApplication(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddServices();
            return services;
        }
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderPositionRepository, OrderPositionRepository>();
            services.AddScoped<IOrderStatusRepository, OrderStatusRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IOrderManagementService, OrderManagementService>();
            return services;
        }
    }
}
