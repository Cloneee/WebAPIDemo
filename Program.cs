using Microsoft.EntityFrameworkCore;
using WebAPIDemo.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ProductContext>(opt =>
    opt.UseInMemoryDatabase("ProductList"));
builder.Services.AddDbContext<CustomerContext>(opt =>
    opt.UseInMemoryDatabase("CustomerList"));
builder.Services.AddDbContext<StaffContext>(opt =>
    opt.UseInMemoryDatabase("StaffList"));
builder.Services.AddDbContext<OrderContext>(opt =>
    opt.UseInMemoryDatabase("OrderList"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ProductContext>();
    DataGenerator.Initialize(services);
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
