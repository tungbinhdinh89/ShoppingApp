using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.DB
{
    public class ShopTypeConfiguration : IEntityTypeConfiguration<ShopType>
    {
        public void Configure(EntityTypeBuilder<ShopType> builder)
        {
            builder.HasKey(st => st.Id);

            builder.Property(st => st.Name)
                   .HasMaxLength(255)
                   .IsRequired();

            builder.HasIndex(st => st.Name).IsUnique();
        }
    }

}
