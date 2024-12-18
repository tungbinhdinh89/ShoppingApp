using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.DB
{
    public class ShippingMethodConfiguration : IEntityTypeConfiguration<ShippingMethod>
    {
        public void Configure(EntityTypeBuilder<ShippingMethod> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                   .HasMaxLength(255)
                   .IsRequired();

            builder.HasIndex(s => s.Name)
                   .IsUnique();
        }
    }
}
