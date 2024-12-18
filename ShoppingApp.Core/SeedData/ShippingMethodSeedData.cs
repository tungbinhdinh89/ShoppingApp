using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.SeedData
{
    public static class ShippingMethodSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShippingMethod>().HasData(
             new ShippingMethod { Id = 1, Name = "Standard Shipping" },
             new ShippingMethod { Id = 2, Name = "Express Shipping" },
             new ShippingMethod { Id = 3, Name = "Overnight Shipping" }
         );
        }
    }
}
