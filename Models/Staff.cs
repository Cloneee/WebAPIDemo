using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAPIDemo.Models
{
    [Table("Staff")]
    public class Staff
    {
        [Key]
        public string StaffId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public virtual ICollection<Order> Order {get ; set; }
    }
}

