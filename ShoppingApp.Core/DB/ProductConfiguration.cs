using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.DB
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                   .HasMaxLength(255)
                   .IsRequired();

            builder.Property(p => p.Price)
                   .HasColumnType("money");

            builder.HasIndex(p => p.Name)
                   .IsUnique();

            builder.HasOne(p => p.Brand)
                   .WithMany(b => b.Products)
                   .HasForeignKey(p => p.BrandId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.SubCategory)
                   .WithMany(s => s.Products)
                   .HasForeignKey(p => p.SubCategoryId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.ShopType)
                   .WithMany(s => s.Products)
                   .HasForeignKey(p => p.ShopTypeId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.Reviews)
                   .WithOne(r => r.Product)
                   .HasForeignKey(r => r.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
