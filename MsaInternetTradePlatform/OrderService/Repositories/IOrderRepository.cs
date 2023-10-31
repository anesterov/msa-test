using OrderService.Models.Store;

namespace OrderService.Repositories
{
    public interface IOrderRepository
    {
        Task<OrderEntity> GetOrderAsync(string id, CancellationToken ct);
        
        Task UpdateOrInsertGetOrderAsync(OrderEntity order, CancellationToken ct);
    }
}
