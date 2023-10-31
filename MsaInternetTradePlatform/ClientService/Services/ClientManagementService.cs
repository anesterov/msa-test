using ClientService.Mappers;
using ClientService.Models.Contract;
using ClientService.Models.Store;
using ClientService.Repositories;

namespace ClientService.Services
{
    public class ClientManagementService : IClientManagementService
    {
        private readonly IClientRepository _clientRepository;

        public ClientManagementService(IClientRepository clientRepository) { 
            _clientRepository = clientRepository;
        }

        private ClientGetModel MapFromStore(ClientStoreModel storeObj)
        {
            if (storeObj == null)
            {
                return null;
            }

            return new ClientGetModel
            {
                Email = storeObj.Email,
                Login = storeObj.Login,
            };
        }

        public async Task<string> RegisterAsync(ClientPutModel model, CancellationToken ct)
        {
            var storeModel = ClientMapper.MapToStore(model);
            var id = await _clientRepository.InsertClientAsync(storeModel, ct);
            return id;
        }

        public Task UpdateClientAsync(string id, ClientPutModel model, CancellationToken ct)
        {
            var storeModel = ClientMapper.MapToStore(model);
            storeModel.Id = id;
            return _clientRepository.UpdateClientAsync(storeModel, ct);
        }

        public Task<ClientGetModel> GetClientAsync(string id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
