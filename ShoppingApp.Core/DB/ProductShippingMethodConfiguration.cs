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

            builder.HasOne(po => po.Product)
                 .WithMany(p => p.ProductShippingMethods)
                 .HasForeignKey(po => po.ProductId);

            builder.HasOne(po => po.ShippingMethod)
                   .WithMany(o => o.ProductShippingMethods)
                   .HasForeignKey(po => po.ShippingMethodId);
        }
    }
}
