using ClientService.Models.Store;

namespace ClientService.Repositories
{
    public class ClientRepository: IClientRepository
    {
        public Task<ClientStoreModel> GetClientAsync(string id, CancellationToken ct)
        {
            var result = new ClientStoreModel
            {
                Id = id,
                Login = "stub_only",
                Email = "test@tes.ru",
                PasswordHash = "****",
            };
            return Task.FromResult(result);
        }

        public Task<string> InsertClientAsync(ClientStoreModel model, CancellationToken ct)
        {
            return Task.FromResult(model.Id ?? "1");
        }

        public Task UpdateClientAsync(ClientStoreModel model, CancellationToken ct)
        {
            return Task.CompletedTask;
        }
}
}
