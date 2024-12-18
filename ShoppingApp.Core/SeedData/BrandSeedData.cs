using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.SeedData
{
    public static class BrandSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "JBL" },
                new Brand { Id = 2, Name = "Sony" },
                new Brand { Id = 3, Name = "Bose" },
                new Brand { Id = 4, Name = "Samsung" },
                new Brand { Id = 5, Name = "ONTEKCO" }
            );
        }
    }
}
