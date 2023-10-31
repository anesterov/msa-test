namespace ClientService.Models.Contract
{
    public class ClientPutModel
    {
        public string Login { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

    }
}
