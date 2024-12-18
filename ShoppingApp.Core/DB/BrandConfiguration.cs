using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.DB
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            // Primary Key
            builder.HasKey(b => b.Id);

            // Properties
            builder.Property(b => b.Name)
                   .HasMaxLength(256)
                   .IsRequired();

            builder.HasIndex(b => b.Name).IsUnique();
        }
    }

}
