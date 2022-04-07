using Microsoft.EntityFrameworkCore;

namespace WebAPIDemo.Models
{
    public class OrderItemContext : DbContext
    {
        public OrderItemContext(DbContextOptions<OrderItemContext> options)
            : base(options)
        {
        }

        public DbSet<OrderItem> OrderItem { get; set; } = null!;
    }
}
