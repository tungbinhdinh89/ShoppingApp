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

            builder.HasOne(po => po.Product)
                   .WithMany(p => p.ProductLocations)
                   .HasForeignKey(po => po.ProductId)
                   .OnDelete(DeleteBehavior.Restrict); ;

            builder.HasOne(po => po.Location)
                   .WithMany(o => o.ProductLocations)
                   .HasForeignKey(po => po.LocationId)
                   .OnDelete(DeleteBehavior.Restrict); ;

        }
    }
}
