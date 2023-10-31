namespace OrderService.Models.Store
{
    public class OrderStatusEntity
    {
        public string OrderId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
