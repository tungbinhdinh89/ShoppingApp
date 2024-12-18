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

            builder.HasOne(po => po.Product)
                   .WithMany(p => p.ProductConditions)
                   .HasForeignKey(po => po.ProductId)
                   .OnDelete(DeleteBehavior.Restrict); ;

            builder.HasOne(po => po.Condition)
                   .WithMany(o => o.ProductConditions)
                   .HasForeignKey(po => po.ConditionId)
                   .OnDelete(DeleteBehavior.Restrict); ;
        }
    }
}
