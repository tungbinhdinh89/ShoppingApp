using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.SeedData
{
    public static class ProductConditionSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var conditions = new List<ProductCondition>();
            for (int i = 1; i <= 50; i++)
            {
                conditions.Add(new ProductCondition { ProductId = i, ConditionId = (i % 2) + 1 });
            }

            modelBuilder.Entity<ProductCondition>().HasData(conditions);
        }
    }
}
