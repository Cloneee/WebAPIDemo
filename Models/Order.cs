using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAPIDemo.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public string OrderId { get; set; }
        public string OrderItemId { get; set; }
        public string CustomerId { get; set; }
        public string StaffId { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}