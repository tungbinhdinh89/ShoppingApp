using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.SeedData
{
    public static class ProductPromotionSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var promotions = new List<ProductPromotion>();
            for (int i = 1; i <= 50; i++)
            {
                promotions.Add(new ProductPromotion { ProductId = i, PromotionId = (i % 2) + 1 });
            }

            modelBuilder.Entity<ProductPromotion>().HasData(promotions);
        }
    }
}
