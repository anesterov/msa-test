namespace OrderService.Models.Contract
{
    public class Order
    {
        public string Id { get; set; }

        public string ClientId { get; set; }

        public DateTime? OrderStartDate { get; set; }

        public OrderStatus[] Statuses { get; set; }

        public OrderPosition[] Positions { get; set;}
    }
}
