using OrderService.Models.Store;

namespace OrderService.Repositories
{
    public interface IOrderPositionRepository
    {
        Task UpdateOrInsertOrderPositionAsync(OrderPositionEntity OrderPosition, CancellationToken ct);
        Task<IEnumerable<OrderPositionEntity>> GetPositionsAsync(string orderId, CancellationToken ct);
    }
}
