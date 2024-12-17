using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.DB
{
    public class ProductLocationConfiguration : IEntityTypeConfiguration<ProductLocation>
    {
        public void Configure(EntityTypeBuilder<ProductLocation> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.LocationId });

            builder.HasOne(p => p.Product)
                   .WithMany(x => x.ProductLocations)
                   .HasForeignKey(p => p.ProductId);

            builder.HasOne(l => l.Location)
                   .WithMany(x => x.ProductLocations)
                   .HasForeignKey(l => l.LocationId);
        }
    }
}
