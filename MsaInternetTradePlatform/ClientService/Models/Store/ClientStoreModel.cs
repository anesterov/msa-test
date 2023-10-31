namespace ClientService.Models.Store
{
    public class ClientStoreModel
    {
        public string Id { get; set; }

        public string Login { get; set; }

        public string PasswordHash { get; set; }

        public string Email { get; set; }
    }
}
