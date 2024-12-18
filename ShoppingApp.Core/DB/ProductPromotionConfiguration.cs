using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.DB
{
    public class ProductPromotionConfiguration : IEntityTypeConfiguration<ProductPromotion>
    {
        public void Configure(EntityTypeBuilder<ProductPromotion> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.PromotionId });

            builder.HasOne(po => po.Product)
                 .WithMany(p => p.ProductPromotions)
                 .HasForeignKey(po => po.ProductId)
                 .OnDelete(DeleteBehavior.Restrict); ;

            builder.HasOne(po => po.Promotion)
                   .WithMany(o => o.ProductPromotions)
                   .HasForeignKey(po => po.PromotionId)
                   .OnDelete(DeleteBehavior.Restrict); ;
        }
    }
}
