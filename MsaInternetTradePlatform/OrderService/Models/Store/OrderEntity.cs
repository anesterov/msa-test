namespace OrderService.Models.Store
{
    public class OrderEntity
    {
        public string Id { get; set; }

        public string ClientId { get; set; }

        public DateTime? OrderStartDate { get; set; }
    }
}
