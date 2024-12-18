using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.SeedData
{
    public static class ProductShippingMethodSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var shippingMethods = new List<ProductShippingMethod>();
            for (int i = 1; i <= 50; i++)
            {
                shippingMethods.Add(new ProductShippingMethod { ProductId = i, ShippingMethodId = (i % 3) + 1 });
            }

            modelBuilder.Entity<ProductShippingMethod>().HasData(shippingMethods);
        }
    }
}
