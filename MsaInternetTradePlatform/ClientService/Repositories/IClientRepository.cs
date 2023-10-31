using ClientService.Models.Store;

namespace ClientService.Repositories
{
    public interface IClientRepository
    {
        Task<ClientStoreModel> GetClientAsync(string id, CancellationToken ct);

        Task<string> InsertClientAsync(ClientStoreModel model, CancellationToken ct);

        Task UpdateClientAsync(ClientStoreModel model, CancellationToken ct);
    }
}
