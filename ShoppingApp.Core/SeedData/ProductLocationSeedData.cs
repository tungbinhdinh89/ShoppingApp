using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.SeedData
{
    public static class ProductLocationSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var locations = new List<ProductLocation>();
            for (int i = 1; i <= 50; i++)
            {
                locations.Add(new ProductLocation { ProductId = i, LocationId = (i % 3) + 1 });
            }

            modelBuilder.Entity<ProductLocation>().HasData(locations);
        }
    }
}
