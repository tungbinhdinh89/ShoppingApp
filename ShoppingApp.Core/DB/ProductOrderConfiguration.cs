using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.DB
{
    public class ProductOrderConfiguration : IEntityTypeConfiguration<ProductOrder>
    {
        public void Configure(EntityTypeBuilder<ProductOrder> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.OrderId });

            builder.HasOne(po => po.Product)
                   .WithMany(p => p.ProductOrders)
                   .HasForeignKey(po => po.ProductId)
                   .OnDelete(DeleteBehavior.Restrict); ;

            builder.HasOne(po => po.Order)
                   .WithMany(o => o.ProductOrders)
                   .HasForeignKey(po => po.OrderId)
                   .OnDelete(DeleteBehavior.Restrict); ;
        }
    }
}
