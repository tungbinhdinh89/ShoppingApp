using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.SeedData
{
    public static class OrderSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var orders = new List<Order>();
            for (int i = 1; i <= 50; i++)
            {
                orders.Add(new Order { Id = i, Name = $"Order{i}", Quantity = (i % 5) + 1, OrderDate = DateTime.UtcNow });
            }

            modelBuilder.Entity<Order>().HasData(orders);
        }
    }
}
