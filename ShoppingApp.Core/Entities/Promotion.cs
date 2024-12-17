using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Core.Entities
{
    public class Promotion
    {
        public int Id { get; set; }

        [MaxLength(255), Required]
        public string Name { get; set; } = string.Empty;
        [MaxLength(1000)]
        public string Description { get; set; } = string.Empty;

        public ICollection<ProductPromotion> ProductPromotions { get; set; } = [];
    }
}
