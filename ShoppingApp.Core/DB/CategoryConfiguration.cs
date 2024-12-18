using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.DB
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
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
