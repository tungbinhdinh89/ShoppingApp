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

            builder.HasOne(p => p.Product)
                   .WithMany(x => x.ProductPromotions)
                   .HasForeignKey(p => p.ProductId);

            builder.HasOne(l => l.Promotion)
                   .WithMany(x => x.ProductPromotions)
                   .HasForeignKey(l => l.PromotionId);
        }
    }
}
