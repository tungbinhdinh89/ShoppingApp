using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.DB
{
    public class ProductShippingMethodConfiguration : IEntityTypeConfiguration<ProductShippingMethod>
    {
        public void Configure(EntityTypeBuilder<ProductShippingMethod> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.ShippingMethodId });

            builder.HasOne(p => p.Product)
                   .WithMany(x => x.ProductShippingMethods)
                   .HasForeignKey(p => p.ProductId);

            builder.HasOne(l => l.ShippingMethod)
                   .WithMany(x => x.ProductShippingMethods)
                   .HasForeignKey(l => l.ShippingMethodId);
        }
    }
}
