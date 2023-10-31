using Microsoft.AspNetCore.Mvc;
using OrderService.Models.Contract;
using OrderService.Services;

namespace OrderService.Controllers
{
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IOrderManagementService _service;

        public OrderController(ILogger<OrderController> logger, IOrderManagementService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("orders/{id}")]
        public async Task<ActionResult<Order>> GetClienAsync(string id, CancellationToken ct)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var order = await _service.GetOrderAsync(id, ct);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpPut("orders")]
        public async Task<ActionResult> PutClienAsync([FromBody] Order order, CancellationToken ct)
        {
            if (order == null)
            {
                return BadRequest();
            }

            await _service.CreateOrderAsync(order, ct);

            return Ok();
        }

        [HttpPut("orders/{id}/statuses/{status}")]
        public async Task<ActionResult> ChangeStatusAsync(string id, int status, CancellationToken ct)
        {
            if (status <= 0 || string.IsNullOrEmpty(id))
            {
                return BadRequest();
            }

            if (!await _service.OrderExistsAsync(id, ct))
            {
                return NotFound();
            }

            await _service.ChangeOrderStatusAsync(id, status, ct);

            return Ok();
        }

        [HttpPost("orders/{id}/positions")]
        public async Task<ActionResult> SetPositionAsync(string id, [FromBody] OrderPosition position, CancellationToken ct)
        {
            if (position == null || string.IsNullOrEmpty(id))
            {
                return BadRequest();
            }

            if (!await _service.OrderExistsAsync(id, ct))
            {
                return NotFound();
            }

            await _service.AddOrUpdatePositionAsync(id, position, ct);

            return Ok();
        }

    }
}