using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.SeedData
{
    public static class LocationSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasData(
          new Location { Id = 1, Name = "Ha Noi" },
          new Location { Id = 2, Name = "Ho Chi Minh" },
          new Location { Id = 3, Name = "Da Nang" }
      );
        }
    }
}
