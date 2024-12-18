using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.SeedData
{
    public static class PromotionSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Promotion>().HasData(
             new Promotion { Id = 1, Name = "On Sale" },
             new Promotion { Id = 2, Name = "Best Price" }
         );
        }
    }
}
