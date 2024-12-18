using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.SeedData
{
    public static class CategorySeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Audio Devices" },
            new Category { Id = 2, Name = "Gaming" },
            new Category { Id = 3, Name = "Accessories" }
        );
        }
    }
}
