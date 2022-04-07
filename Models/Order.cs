namespace WebAPIDemo.Models
{
    public class Order
    {
        public string Id { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public string CustomerId { get; set; }
        public string StaffId {get; set; }
    }
}