using ClientService.Models.Contract;

namespace ClientService.Services
{
    public interface IClientManagementService
    {
        Task<ClientGetModel> GetClientAsync(string id, CancellationToken ct);

        Task<string> RegisterAsync(ClientPutModel model, CancellationToken ct);

        Task UpdateClientAsync(string id, ClientPutModel model, CancellationToken ct);
    }
}
