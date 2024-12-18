using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.SeedData
{
    public static class ConditionSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Condition>().HasData(
             new Condition { Id = 1, Name = "New" },
             new Condition { Id = 2, Name = "Used" }
         );
        }
    }
}
