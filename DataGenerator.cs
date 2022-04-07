
using Microsoft.EntityFrameworkCore;

namespace WebAPIDemo.Models;
public class DataGenerator
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ProductContext(
            serviceProvider.GetRequiredService<DbContextOptions<ProductContext>>()))
        {
            // Look for any board games.
            if (context.Product.Any())
            {
                return;   // Data was already seeded
            }

            context.Product.AddRange(
                new Product
                {
                    ProductId = "001",
                    Name = "Cà phê sữa",
                    Price = 27000,
                    Description = "Cà phê sữa thơm ngon, thôi tui không chờ bạn nữa giờ tui uống liên"
                },
                new Product
                {
                    ProductId = "002",
                    Name = "Cà phê đen",
                    Price = 25000,
                    Description = "Cà phê đen thơm ngon, thôi tui không chờ bạn nữa giờ tui uống liên"
                },
                new Product
                {
                    ProductId = "003",
                    Name = "Americano",
                    Price = 29000
                },
                new Product
                {
                    ProductId = "004",
                    Name = "Moca",
                    Price = 29000
                },
                new Product
                {
                    ProductId = "005",
                    Name = "Esspresso",
                    Price = 25000
                }
                );

            context.SaveChanges();
        }
        using (var context = new StaffContext(
            serviceProvider.GetRequiredService<DbContextOptions<StaffContext>>()))
        {
            // Look for any board games.
            if (context.Staff.Any())
            {
                return;   // Data was already seeded
            }

            context.Staff.AddRange(
                new Staff
                {
                    StaffId = "001",
                    Username = "huypropropro",
                    Password = "123456",
                    Email = "thanhhuy@gmail.com",
                    Role = "Admin"
                },
                new Staff
                {
                    StaffId = "002",
                    Username = "huymana",
                    Password = "123456",
                    Email = "thanhhuy2@gmail.com",
                    Role = "Manager"
                },
                new Staff
                {
                    StaffId = "003",
                    Username = "huystaff",
                    Password = "123456",
                    Email = "thanhhuy3@gmail.com",
                    Role = "Staff"
                }
                );

            context.SaveChanges();
        }
        using (var context = new CustomerContext(
            serviceProvider.GetRequiredService<DbContextOptions<CustomerContext>>()))
        {
            // Look for any board games.
            if (context.Customer.Any())
            {
                return;   // Data was already seeded
            }

            context.Customer.AddRange(
                new Customer
                {
                    CustomerId = "001",
                    Username = "khachhang1",
                    Password = "123456",
                    Email = "khachhang1@gmail.com"
                },
                new Customer
                {
                    CustomerId = "002",
                    Username = "khachhang2",
                    Password = "123456",
                    Email = "khachhang2@gmail.com"
                },
                new Customer
                {
                    CustomerId = "003",
                    Username = "khachhang3",
                    Password = "123456",
                    Email = "khachhang3@gmail.com"
                }
                );

            context.SaveChanges();
        }
using (var context = new OrderItemContext(
            serviceProvider.GetRequiredService<DbContextOptions<OrderItemContext>>()))
        {
            // Look for any board games.
            if (context.OrderItem.Any())
            {
                return;   // Data was already seeded
            }

            context.OrderItem.AddRange(
                new OrderItem
                {
                    OrderItemId = "001",
                },
                new OrderItem
                {
                    OrderItemId = "002",
                },
                new OrderItem
                {
                    OrderItemId = "003",
                }
                );

            context.SaveChanges();
        }
        using (var context = new OrderContext(
            serviceProvider.GetRequiredService<DbContextOptions<OrderContext>>()))
        {
            if (context.Order.Any())
            {
                return;   // Data was already seeded
            }

            context.Order.AddRange(
                new Order
                {
                    OrderId = "001",
                    CustomerId = "002",
                    StaffId = "001"
                },
                new Order
                {
                    OrderId = "002",
                    CustomerId = "003",
                    StaffId = "003"
                },
                new Order
                {
                    OrderId = "003",
                    CustomerId = "002",
                    StaffId = "002"
                }
                );

            context.SaveChanges();
        }
    }
}
