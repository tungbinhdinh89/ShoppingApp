using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.SeedData
{
    public static class ProductSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "JBL Flip 5", Price = 320000, BrandId = 1, SubCategoryId = 1, ShopTypeId = 1, CreatedDate = DateTime.UtcNow, ViewCount = 100, SoldCount = 50 },
    new Product { Id = 2, Name = "Sony SRS-XB13", Price = 450000, BrandId = 2, SubCategoryId = 1, ShopTypeId = 2, CreatedDate = DateTime.UtcNow, ViewCount = 150, SoldCount = 75 },
    new Product { Id = 3, Name = "Bose SoundLink Mini II", Price = 600000, BrandId = 3, SubCategoryId = 1, ShopTypeId = 3, CreatedDate = DateTime.UtcNow, ViewCount = 120, SoldCount = 60 },
    new Product { Id = 4, Name = "Samsung Sound Tower", Price = 1200000, BrandId = 4, SubCategoryId = 2, ShopTypeId = 1, CreatedDate = DateTime.UtcNow, ViewCount = 200, SoldCount = 80 },
    new Product { Id = 5, Name = "ONTEKCO Bluetooth Speaker", Price = 599000, BrandId = 5, SubCategoryId = 1, ShopTypeId = 4, CreatedDate = DateTime.UtcNow, ViewCount = 130, SoldCount = 55 },
    new Product { Id = 6, Name = "Sony WH-1000XM4", Price = 8000000, BrandId = 2, SubCategoryId = 3, ShopTypeId = 1, CreatedDate = DateTime.UtcNow, ViewCount = 320, SoldCount = 180 },
    new Product { Id = 7, Name = "JBL Tune 510BT", Price = 1200000, BrandId = 1, SubCategoryId = 3, ShopTypeId = 4, CreatedDate = DateTime.UtcNow, ViewCount = 290, SoldCount = 150 },
    new Product { Id = 8, Name = "Bose QuietComfort 35 II", Price = 9500000, BrandId = 3, SubCategoryId = 3, ShopTypeId = 1, CreatedDate = DateTime.UtcNow, ViewCount = 350, SoldCount = 200 },
    new Product { Id = 9, Name = "Samsung Galaxy Buds Live", Price = 3000000, BrandId = 4, SubCategoryId = 3, ShopTypeId = 4, CreatedDate = DateTime.UtcNow, ViewCount = 240, SoldCount = 130 },
    new Product { Id = 10, Name = "ONTEKCO Smartwatch", Price = 2500000, BrandId = 5, SubCategoryId = 2, ShopTypeId = 3, CreatedDate = DateTime.UtcNow, ViewCount = 150, SoldCount = 60 },
    new Product { Id = 11, Name = "Sony WH-XB900N", Price = 6500000, BrandId = 2, SubCategoryId = 3, ShopTypeId = 2, CreatedDate = DateTime.UtcNow, ViewCount = 310, SoldCount = 160 },
    new Product { Id = 12, Name = "Samsung Galaxy Watch 4", Price = 6000000, BrandId = 4, SubCategoryId = 2, ShopTypeId = 2, CreatedDate = DateTime.UtcNow, ViewCount = 350, SoldCount = 170 },
    new Product { Id = 13, Name = "Bose SoundLink Revolve+", Price = 7500000, BrandId = 3, SubCategoryId = 1, ShopTypeId = 1, CreatedDate = DateTime.UtcNow, ViewCount = 280, SoldCount = 150 },
    new Product { Id = 14, Name = "JBL PartyBox 100", Price = 3200000, BrandId = 1, SubCategoryId = 2, ShopTypeId = 3, CreatedDate = DateTime.UtcNow, ViewCount = 270, SoldCount = 140 },
    new Product { Id = 15, Name = "ONTEKCO VR Headset", Price = 10000000, BrandId = 5, SubCategoryId = 4, ShopTypeId = 4, CreatedDate = DateTime.UtcNow, ViewCount = 180, SoldCount = 90 },
    new Product { Id = 16, Name = "Sony Soundbar", Price = 4500000, BrandId = 2, SubCategoryId = 2, ShopTypeId = 2, CreatedDate = DateTime.UtcNow, ViewCount = 220, SoldCount = 120 },
    new Product { Id = 17, Name = "Samsung Gear VR", Price = 5000000, BrandId = 4, SubCategoryId = 4, ShopTypeId = 3, CreatedDate = DateTime.UtcNow, ViewCount = 280, SoldCount = 150 },
    new Product { Id = 18, Name = "JBL Pulse 4", Price = 5500000, BrandId = 1, SubCategoryId = 2, ShopTypeId = 4, CreatedDate = DateTime.UtcNow, ViewCount = 250, SoldCount = 130 },
    new Product { Id = 19, Name = "Bose Smart Soundbar", Price = 12000000, BrandId = 3, SubCategoryId = 2, ShopTypeId = 2, CreatedDate = DateTime.UtcNow, ViewCount = 350, SoldCount = 200 },
    new Product { Id = 20, Name = "ONTEKCO Fitness Band", Price = 1000000, BrandId = 5, SubCategoryId = 2, ShopTypeId = 1, CreatedDate = DateTime.UtcNow, ViewCount = 200, SoldCount = 100 },
    new Product { Id = 21, Name = "Sony Xperia 5", Price = 15000000, BrandId = 2, SubCategoryId = 5, ShopTypeId = 3, CreatedDate = DateTime.UtcNow, ViewCount = 400, SoldCount = 250 },
    new Product { Id = 22, Name = "Samsung Smart Monitor", Price = 8000000, BrandId = 4, SubCategoryId = 5, ShopTypeId = 2, CreatedDate = DateTime.UtcNow, ViewCount = 220, SoldCount = 100 },
    new Product { Id = 23, Name = "Bose Gaming Headset", Price = 9900000, BrandId = 3, SubCategoryId = 4, ShopTypeId = 1, CreatedDate = DateTime.UtcNow, ViewCount = 280, SoldCount = 160 },
    new Product { Id = 24, Name = "JBL Bar 5.1", Price = 18000000, BrandId = 1, SubCategoryId = 2, ShopTypeId = 4, CreatedDate = DateTime.UtcNow, ViewCount = 340, SoldCount = 200 },
    new Product { Id = 25, Name = "ONTEKCO Wireless Charger", Price = 1000000, BrandId = 5, SubCategoryId = 5, ShopTypeId = 1, CreatedDate = DateTime.UtcNow, ViewCount = 150, SoldCount = 50 },
     new Product { Id = 26, Name = "Sony OLED TV", Price = 50000000, BrandId = 2, SubCategoryId = 2, ShopTypeId = 3, CreatedDate = DateTime.UtcNow, ViewCount = 450, SoldCount = 300 },
    new Product { Id = 27, Name = "Samsung QLED TV", Price = 48000000, BrandId = 4, SubCategoryId = 4, ShopTypeId = 2, CreatedDate = DateTime.UtcNow, ViewCount = 410, SoldCount = 290 },
    new Product { Id = 28, Name = "JBL Go 3", Price = 1200000, BrandId = 1, SubCategoryId = 1, ShopTypeId = 1, CreatedDate = DateTime.UtcNow, ViewCount = 210, SoldCount = 150 },
    new Product
    {
        Id = 29,
        Name = "Bose Wave Music System",
        Price = 25000000,
        BrandId = 3,
        SubCategoryId = 2,
        ShopTypeId = 4,
        CreatedDate = DateTime.UtcNow,
        ViewCount = 320,
        SoldCount = 180
    },
     new Product { Id = 30, Name = "ONTEKCO Gaming Keyboard", Price = 3000000, BrandId = 5, SubCategoryId = 5, ShopTypeId = 3, CreatedDate = DateTime.UtcNow, ViewCount = 180, SoldCount = 90 },
    new Product { Id = 31, Name = "Sony WF-1000XM4", Price = 6200000, BrandId = 2, SubCategoryId = 3, ShopTypeId = 4, CreatedDate = DateTime.UtcNow, ViewCount = 310, SoldCount = 190 },
    new Product { Id = 32, Name = "Samsung Frame TV", Price = 60000000, BrandId = 4, SubCategoryId = 5, ShopTypeId = 3, CreatedDate = DateTime.UtcNow, ViewCount = 480, SoldCount = 310 },
    new Product { Id = 33, Name = "JBL Endurance Peak", Price = 2000000, BrandId = 1, SubCategoryId = 3, ShopTypeId = 1, CreatedDate = DateTime.UtcNow, ViewCount = 220, SoldCount = 120 },
    new Product { Id = 34, Name = "Bose Frames", Price = 9000000, BrandId = 3, SubCategoryId = 4, ShopTypeId = 2, CreatedDate = DateTime.UtcNow, ViewCount = 260, SoldCount = 140 },
    new Product { Id = 35, Name = "ONTEKCO Smart Glasses", Price = 7000000, BrandId = 5, SubCategoryId = 4, ShopTypeId = 1, CreatedDate = DateTime.UtcNow, ViewCount = 200, SoldCount = 100 },
    new Product { Id = 36, Name = "Sony HT-Z9F Soundbar", Price = 15000000, BrandId = 2, SubCategoryId = 2, ShopTypeId = 4, CreatedDate = DateTime.UtcNow, ViewCount = 370, SoldCount = 210 },
    new Product { Id = 37, Name = "Samsung Galaxy Tab S7", Price = 14000000, BrandId = 4, SubCategoryId = 5, ShopTypeId = 1, CreatedDate = DateTime.UtcNow, ViewCount = 320, SoldCount = 190 },
    new Product { Id = 38, Name = "JBL Free X", Price = 2200000, BrandId = 1, SubCategoryId = 3, ShopTypeId = 3, CreatedDate = DateTime.UtcNow, ViewCount = 250, SoldCount = 130 },
    new Product { Id = 39, Name = "Bose Noise Cancelling Earbuds", Price = 9500000, BrandId = 3, SubCategoryId = 3, ShopTypeId = 1, CreatedDate = DateTime.UtcNow, ViewCount = 340, SoldCount = 220 },
    new Product { Id = 40, Name = "ONTEKCO Mini Projector", Price = 6000000, BrandId = 5, SubCategoryId = 3, ShopTypeId = 3, CreatedDate = DateTime.UtcNow, ViewCount = 150, SoldCount = 80 },
    new Product { Id = 41, Name = "Sony Alpha a7 III", Price = 50000000, BrandId = 2, SubCategoryId = 1, ShopTypeId = 2, CreatedDate = DateTime.UtcNow, ViewCount = 410, SoldCount = 300 },
    new Product { Id = 42, Name = "Samsung Smart Fridge", Price = 55000000, BrandId = 4, SubCategoryId = 2, ShopTypeId = 4, CreatedDate = DateTime.UtcNow, ViewCount = 390, SoldCount = 270 },
    new Product { Id = 43, Name = "JBL Live 650BTNC", Price = 4000000, BrandId = 1, SubCategoryId = 3, ShopTypeId = 2, CreatedDate = DateTime.UtcNow, ViewCount = 310, SoldCount = 160 },
    new Product { Id = 44, Name = "Bose Home Speaker 500", Price = 12000000, BrandId = 3, SubCategoryId = 1, ShopTypeId = 4, CreatedDate = DateTime.UtcNow, ViewCount = 300, SoldCount = 180 },
    new Product { Id = 45, Name = "ONTEKCO Power Bank", Price = 1000000, BrandId = 5, SubCategoryId = 5, ShopTypeId = 2, CreatedDate = DateTime.UtcNow, ViewCount = 150, SoldCount = 90 },
    new Product { Id = 46, Name = "Sony 4K Projector", Price = 60000000, BrandId = 2, SubCategoryId = 4, ShopTypeId = 1, CreatedDate = DateTime.UtcNow, ViewCount = 500, SoldCount = 320 },
    new Product { Id = 47, Name = "Samsung Neo QLED TV", Price = 70000000, BrandId = 4, SubCategoryId = 3, ShopTypeId = 3, CreatedDate = DateTime.UtcNow, ViewCount = 460, SoldCount = 330 },
    new Product { Id = 48, Name = "JBL Charge 5", Price = 3000000, BrandId = 1, SubCategoryId = 1, ShopTypeId = 1, CreatedDate = DateTime.UtcNow, ViewCount = 210, SoldCount = 140 },
    new Product { Id = 49, Name = "Bose Portable Home Speaker", Price = 15000000, BrandId = 3, SubCategoryId = 1, ShopTypeId = 4, CreatedDate = DateTime.UtcNow, ViewCount = 280, SoldCount = 170 },
    new Product { Id = 50, Name = "ONTEKCO Digital Clock", Price = 800000, BrandId = 5, SubCategoryId = 5, ShopTypeId = 3, CreatedDate = DateTime.UtcNow, ViewCount = 120, SoldCount = 60 }

            );
        }
    }
}
