using OrderService.Mappers;
using OrderService.Models.Contract;
using OrderService.Repositories;

namespace OrderService.Services
{
    public class OrderManagementService : IOrderManagementService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderPositionRepository _orderPositionRepository;
        private readonly IOrderStatusRepository _orderStatusRepository;

        public OrderManagementService(IOrderRepository orderRepository, IOrderPositionRepository orderPositionRepository, IOrderStatusRepository orderStatusRepository) 
        {
            _orderPositionRepository = orderPositionRepository;
            _orderRepository = orderRepository;
            _orderStatusRepository = orderStatusRepository;
        }
        public Task AddOrUpdatePositionAsync(string orderId, OrderPosition position, CancellationToken ct)
        {
            var entity = OrderMapper.MapToStore(position);
            entity.OrderId = orderId;
            _orderPositionRepository.UpdateOrInsertOrderPositionAsync(entity, ct);
            return Task.CompletedTask;
        }

        public Task ChangeOrderStatusAsync(string orderId, int newStatusId, CancellationToken ct)
        {
            var newStatus = new OrderStatus
            {
                Date = DateTime.UtcNow,
                Id = newStatusId,
            };

            var entity = OrderMapper.MapToStore(newStatus);
            entity.OrderId = orderId;
            _orderStatusRepository.InsertOrderStatusAsync(entity, ct);
            return Task.CompletedTask;
        }

        public Task CreateOrderAsync(Order order, CancellationToken ct)
        {
            var entity = OrderMapper.MapToStore(order);
            _orderRepository.UpdateOrInsertGetOrderAsync(entity, ct);
            return Task.CompletedTask;
        }

        public async Task<Order> GetOrderAsync(string id, CancellationToken ct)
        {
            var order = await _orderRepository.GetOrderAsync(id, ct);
            var positions = await _orderPositionRepository.GetPositionsAsync(id, ct);
            var statuses = await _orderStatusRepository.GetStatusesAsync(id, ct);
            var result = OrderMapper.MapFromStore(order);
            if (result != null)
            {
                result.Positions = positions.Select(OrderMapper.MapFromStore).ToArray();
                result.Statuses = statuses.Select(OrderMapper.MapFromStore).ToArray();
            }
            return result;
        }

        public async Task<bool> OrderExistsAsync(string id, CancellationToken ct)
        {
            var order = await _orderRepository.GetOrderAsync(id, ct);
            return order != null;
        }
    }
}
