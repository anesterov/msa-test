namespace OrderService.Models.Contract
{
    public class OrderPosition
    {
        public string ItemId { get; set; }
        public decimal ItemQuantity { get; set; }
        public decimal ItemPrice { get; set; }
    }
}
