using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

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

        public DbSet<ProductLocation> ProductLocations { get; set; }
        public DbSet<ProductPromotion> ProductPromotions { get; set; }
        public DbSet<ProductCondition> ProductConditions { get; set; }
        public DbSet<ProductShippingMethod> ProductShippingMethods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConditionConfiguration());
            modelBuilder.ApplyConfiguration(new ProductLocationConfiguration());
            modelBuilder.ApplyConfiguration(new ProductPromotionConfiguration());
            modelBuilder.ApplyConfiguration(new ProductShippingMethodConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }


    }
}
