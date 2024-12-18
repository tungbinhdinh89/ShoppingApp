using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.SeedData
{
    public static class ProductOrderSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var productOrders = new List<ProductOrder>();
            var random = new Random();

            for (int i = 1; i <= 50; i++)
            {
                var productsPerOrder = random.Next(1, 6);

                for (int j = 0; j < productsPerOrder; j++)
                {
                    productOrders.Add(new ProductOrder { ProductId = random.Next(1, 51), OrderId = i });
                }
            }

            modelBuilder.Entity<ProductOrder>().HasData(productOrders);
        }
    }
}
