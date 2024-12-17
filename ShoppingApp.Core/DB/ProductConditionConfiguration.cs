using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.DB
{
    public class ProductConditionConfiguration : IEntityTypeConfiguration<ProductCondition>
    {
        public void Configure(EntityTypeBuilder<ProductCondition> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.ConditionId });

            builder.HasOne(p => p.Product)
                   .WithMany(x => x.ProductConditions)
                   .HasForeignKey(p => p.ProductId);

            builder.HasOne(l => l.Condition)
                   .WithMany(x => x.ProductConditions)
                   .HasForeignKey(l => l.ConditionId);
        }
    }
}
