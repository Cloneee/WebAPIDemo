using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAPIDemo.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public string ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public virtual ICollection<OrderItem> OrderItem {get ; set; }
    }
}