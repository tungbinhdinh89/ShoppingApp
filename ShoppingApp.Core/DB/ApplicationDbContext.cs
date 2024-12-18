using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ShoppingApp.Core.Entities;
using ShoppingApp.Core.SeedData;

namespace ShoppingApp.Core.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ShopType> ShopTypes { get; set; }
        public DbSet<ShippingMethod> ShippingMethods { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<ProductLocation> ProductLocations { get; set; }
        public DbSet<ProductPromotion> ProductPromotions { get; set; }
        public DbSet<ProductCondition> ProductConditions { get; set; }
        public DbSet<ProductShippingMethod> ProductShippingMethods { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ConditionConfiguration());
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewConfiguration());
            modelBuilder.ApplyConfiguration(new ShopTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ShippingMethodConfiguration());
            modelBuilder.ApplyConfiguration(new SubCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());

            modelBuilder.ApplyConfiguration(new ProductConditionConfiguration());
            modelBuilder.ApplyConfiguration(new ProductLocationConfiguration());
            modelBuilder.ApplyConfiguration(new ProductPromotionConfiguration());
            modelBuilder.ApplyConfiguration(new ProductShippingMethodConfiguration());
            modelBuilder.ApplyConfiguration(new ProductOrderConfiguration());

            // Seed Brands
            BrandSeedData.Seed(modelBuilder);

            // Seed Categories
            CategorySeedData.Seed(modelBuilder);

            // Seed SubCategories
            SubCategorySeedData.Seed(modelBuilder);

            // Seed ShopTypes
            ShopTypeSeedData.Seed(modelBuilder);

            // Seed Conditions
            ConditionSeedData.Seed(modelBuilder);

            // Seed Promotions
            PromotionSeedData.Seed(modelBuilder);

            // Shipping Methods
            ShippingMethodSeedData.Seed(modelBuilder);

            // Seed Locations
            LocationSeedData.Seed(modelBuilder);

            // Product Promotions
            ProductPromotionSeedData.Seed(modelBuilder);

            // Product Conditions
            ProductConditionSeedData.Seed(modelBuilder);

            // Product Locations
            ProductLocationSeedData.Seed(modelBuilder);

            // Product Shipping Methods
            ProductShippingMethodSeedData.Seed(modelBuilder);

            // Seed Products
            ProductSeedData.Seed(modelBuilder);

            // Seed Reviews
            ReviewSeedData.Seed(modelBuilder);

            // Seed ProductOrders
            //ProductOrderSeedData.Seed(modelBuilder);

            // Seed Orders
            //OrderSeedData.Seed(modelBuilder);
        }
    }
}
