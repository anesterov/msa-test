using OrderService.Models.Store;

namespace OrderService.Repositories
{
    public class OrderPositionRepository : IOrderPositionRepository
    {
        public Task<IEnumerable<OrderPositionEntity>> GetPositionsAsync(string orderId, CancellationToken ct)
        {
            return Task.FromResult((new List<OrderPositionEntity>()).AsEnumerable());
        }

        public Task UpdateOrInsertOrderPositionAsync(OrderPositionEntity OrderPosition, CancellationToken ct)
        {
            return Task.CompletedTask;
        }
    }
}
