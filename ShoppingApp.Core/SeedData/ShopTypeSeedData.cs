using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.SeedData
{
    public static class ShopTypeSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShopType>().HasData(
          new ShopType { Id = 1, Name = "Shopee Mall" },
          new ShopType { Id = 2, Name = "Favorite Shop" },
          new ShopType { Id = 3, Name = "Processed By Shopee" },
          new ShopType { Id = 4, Name = "Favorite Shop Plus" }
      );
        }
    }
}
