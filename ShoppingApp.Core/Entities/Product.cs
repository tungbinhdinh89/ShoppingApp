using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingApp.Core.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        [MaxLength(255), Required]
        public string ProductName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; } = new Brand();

        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; } = new SubCategory();

        public int ShopTypeId { get; set; }
        public ShopType ShopType { get; set; } = new ShopType();

        public ICollection<ProductLocation> ProductLocations { get; set; } = [];
        public ICollection<ProductCondition> ProductConditions { get; set; } = [];
        public ICollection<ProductPromotion> ProductPromotions { get; set; } = [];
        public ICollection<ProductShippingMethod> ProductShippingMethods { get; set; } = [];
        public ICollection<Review> Reviews { get; set; } = [];
    }
}
