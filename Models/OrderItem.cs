using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAPIDemo.Models
{
    [Table("OrderItem")]
    public class OrderItem
    {
        [Key]
        public string OrderItemId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}