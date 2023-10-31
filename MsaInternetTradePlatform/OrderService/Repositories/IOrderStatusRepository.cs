using OrderService.Models.Store;

namespace OrderService.Repositories
{
    public interface IOrderStatusRepository
    {
        Task InsertOrderStatusAsync(OrderStatusEntity OrderStatus, CancellationToken ct);
        Task<IEnumerable<OrderStatusEntity>> GetStatusesAsync(string orderId, CancellationToken ct);
    }
}
