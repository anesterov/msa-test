using ClientService.Models.Contract;
using ClientService.Models.Store;

namespace ClientService.Mappers
{
    public static class ClientMapper
    {
        public static ClientGetModel MapFromStore(ClientStoreModel storeObj)
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

        public static ClientStoreModel MapToStore(ClientPutModel obj)
        {
            if (obj == null)
            {
                return null;
            }

            return new ClientStoreModel
            {
                Email = obj.Email,
                Login = obj.Login,
                PasswordHash = obj.PasswordHash,
            };
        }
    }
}
