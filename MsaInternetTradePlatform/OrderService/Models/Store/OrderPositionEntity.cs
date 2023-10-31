namespace OrderService.Models.Store
{
    public class OrderPositionEntity
    {
        public string OrderId { get; set; }
        public string ItemId { get; set; }
        public decimal ItemQuantity { get; set; }
        public decimal ItemPrice { get; set; }
    }
}
