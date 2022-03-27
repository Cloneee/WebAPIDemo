using Microsoft.EntityFrameworkCore;

namespace Product.Models
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
