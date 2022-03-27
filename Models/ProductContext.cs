using Microsoft.EntityFrameworkCore;

namespace WebAPIDemo.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<Coffee> Coffee { get; set; } = null!;
    }
}
