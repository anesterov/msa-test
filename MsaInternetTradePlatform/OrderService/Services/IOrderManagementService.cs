using OrderService.Models.Contract;

namespace OrderService.Services
{
    public interface IOrderManagementService
    {
        Task<bool> OrderExistsAsync(string id, CancellationToken ct);

        Task<Order> GetOrderAsync(string id, CancellationToken ct);

        Task CreateOrderAsync(Order order, CancellationToken ct);

        Task ChangeOrderStatusAsync(string orderId, int newStatusId, CancellationToken ct);

        Task AddOrUpdatePositionAsync(string orderId, OrderPosition position, CancellationToken ct);
    }
}
