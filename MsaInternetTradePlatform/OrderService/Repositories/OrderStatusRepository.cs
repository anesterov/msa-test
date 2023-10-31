using OrderService.Models.Store;

namespace OrderService.Repositories
{
    public class OrderStatusRepository : IOrderStatusRepository
    {
        public Task<IEnumerable<OrderStatusEntity>> GetStatusesAsync(string orderId, CancellationToken ct)
        {
            return Task.FromResult((new List<OrderStatusEntity>()).AsEnumerable());
        }

        public Task InsertOrderStatusAsync(OrderStatusEntity OrderStatus, CancellationToken ct)
        {
            return Task.CompletedTask;
        }
    }
}
