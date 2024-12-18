using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.SeedData
{
    public static class SubCategorySeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubCategory>().HasData(
                new SubCategory { Id = 1, Name = "Bluetooth Speaker", CategoryId = 1 },
                new SubCategory { Id = 2, Name = "Wired Speaker", CategoryId = 1 },
                new SubCategory { Id = 3, Name = "Headphones", CategoryId = 1 },
                new SubCategory { Id = 4, Name = "Gaming Consoles", CategoryId = 2 },
                new SubCategory { Id = 5, Name = "Accessories", CategoryId = 3 }
            );
        }
    }
}
