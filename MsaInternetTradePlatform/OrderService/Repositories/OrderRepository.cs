using OrderService.Models.Store;

namespace OrderService.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Task<OrderEntity> GetOrderAsync(string id, CancellationToken ct)
        {
            return Task.FromResult(new OrderEntity());
        }

        public Task UpdateOrInsertGetOrderAsync(OrderEntity order, CancellationToken ct)
        {
            return Task.CompletedTask;
        }
    }
}
