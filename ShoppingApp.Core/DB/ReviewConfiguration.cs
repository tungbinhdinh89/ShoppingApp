using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.Core.DB
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Rating)
                   .HasMaxLength(5)
                   .IsRequired();

            builder.Property(r => r.Comment)
                   .HasMaxLength(500);
        }
    }

}
