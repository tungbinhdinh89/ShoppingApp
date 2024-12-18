using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.SeedData
{
    public static class ReviewSeedData
    {
        //public static void Seed(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Review>().HasData(
        //        new Review { Id = 1, Rating = "5", Comment = "Great sound quality, very pleased with the product.", ProductId = 1 },
        //        new Review { Id = 2, Rating = "4", Comment = "Good sound but the battery life could be better.", ProductId = 2 },
        //        new Review { Id = 3, Rating = "3", Comment = "Decent sound but not as loud as I expected.", ProductId = 3 },
        //        new Review { Id = 4, Rating = "5", Comment = "Excellent sound, worth the price!", ProductId = 4 },
        //        new Review { Id = 5, Rating = "4", Comment = "Good value for money, but a bit bulky.", ProductId = 5 },
        //        new Review { Id = 6, Rating = "5", Comment = "Best gaming console I’ve ever owned.", ProductId = 6 },
        //        new Review { Id = 7, Rating = "2", Comment = "Not very comfortable for long gaming sessions.", ProductId = 7 },
        //        new Review { Id = 8, Rating = "5", Comment = "Perfect for portable gaming, love it!", ProductId = 8 },
        //        new Review { Id = 9, Rating = "4", Comment = "Comfortable and great noise cancellation.", ProductId = 9 },
        //        new Review { Id = 10, Rating = "5", Comment = "Amazing sound quality for the price.", ProductId = 10 },
        //        new Review { Id = 11, Rating = "4", Comment = "Great sound, but a little tight on the ears.", ProductId = 11 },
        //        new Review { Id = 12, Rating = "3", Comment = "Good but the battery doesn’t last as long as I’d like.", ProductId = 12 },
        //        new Review { Id = 13, Rating = "5", Comment = "Great for parties, the sound fills the room.", ProductId = 13 },
        //        new Review { Id = 14, Rating = "5", Comment = "Excellent sound and easy to use.", ProductId = 14 },
        //        new Review { Id = 15, Rating = "4", Comment = "Good bass but not as clear as I expected.", ProductId = 15 },
        //        new Review { Id = 16, Rating = "5", Comment = "Fantastic sound quality and design.", ProductId = 16 },
        //        new Review { Id = 17, Rating = "4", Comment = "Great product, but a bit expensive.", ProductId = 17 },
        //        new Review { Id = 18, Rating = "5", Comment = "Best speaker for the price, highly recommend.", ProductId = 18 },
        //        new Review { Id = 19, Rating = "5", Comment = "Great for gaming and media, very happy with the purchase.", ProductId = 19 },
        //        new Review { Id = 20, Rating = "3", Comment = "The sound is good, but the build quality could be better.", ProductId = 20 },
        //        new Review { Id = 21, Rating = "4", Comment = "Great sound for music, but a bit expensive.", ProductId = 21 },
        //        new Review { Id = 22, Rating = "5", Comment = "Awesome portable speaker with great sound quality.", ProductId = 22 },
        //        new Review { Id = 23, Rating = "4", Comment = "Very good speaker, but could use more bass.", ProductId = 23 },
        //        new Review { Id = 24, Rating = "5", Comment = "Amazing headphones, very comfortable for long use.", ProductId = 24 },
        //        new Review { Id = 25, Rating = "5", Comment = "Excellent sound and bass, works perfectly.", ProductId = 25 },
        //        new Review { Id = 26, Rating = "4", Comment = "Good sound quality, but the design is a bit outdated.", ProductId = 26 },
        //        new Review { Id = 27, Rating = "5", Comment = "Incredible sound, well worth the price.", ProductId = 27 },
        //        new Review { Id = 28, Rating = "5", Comment = "Perfect VR experience, highly recommend.", ProductId = 28 },
        //        new Review { Id = 29, Rating = "4", Comment = "Good speaker, but the battery life could be longer.", ProductId = 29 },
        //        new Review { Id = 30, Rating = "5", Comment = "Top-tier phone, the display is amazing.", ProductId = 30 }
        //    );
        //}
        public static void Seed(ModelBuilder modelBuilder)
        {
            var reviews = new List<Review>();

            for (int i = 1; i <= 50; i++)
            {
                reviews.Add(new Review
                {
                    Id = i,
                    Rating = (i % 5 + 1).ToString(),
                    Comment = $"Review comment for product {i}",
                    ProductId = i
                });
            }

            modelBuilder.Entity<Review>().HasData(reviews);
        }
    }
}
