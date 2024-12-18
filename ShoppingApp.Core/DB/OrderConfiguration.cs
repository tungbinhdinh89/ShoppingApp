using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.DB
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
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
