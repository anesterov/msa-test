using ClientService.Models.Contract;
using ClientService.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClientService.Controllers
{
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private readonly IClientManagementService _service;

        public ClientController(ILogger<ClientController> logger, IClientManagementService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("clients/{id}")]
        public async Task<ActionResult<ClientGetModel>> GetClientAsync(string id, CancellationToken ct)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var client = await _service.GetClientAsync(id, ct);
            if (client == null)
            {
                return NotFound();
            }
            return Ok(client);
        }

        [HttpPut("clients")]
        public async Task<ActionResult<string>> PutClientAsync([FromBody] ClientPutModel client, CancellationToken ct)
        {
            if (client == null)
            {
                return BadRequest();
            }

            var newId = await _service.RegisterAsync(client, ct);

            return Ok(newId);
        }

        [HttpPost("clients/{id}")]
        public async Task<ActionResult> UpdateClientAsync(string id, [FromBody] ClientPutModel client, CancellationToken ct)
        {
            if (client == null)
            {
                return BadRequest();
            }

            var clientFromBase = await _service.GetClientAsync(id, ct);
            if (clientFromBase == null)
            {
                return NotFound();
            }
            
            await _service.UpdateClientAsync(id, client, ct);
            
            return Ok();
        }
    }
}