namespace ShoppingApp.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public int ViewCount { get; set; } = 0;
        public int SoldCount { get; set; } = 0;

        public int BrandId { get; set; }
        public Brand? Brand { get; set; }

        public int SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }

        public int ShopTypeId { get; set; }
        public ShopType? ShopType { get; set; }

        public ICollection<ProductLocation> ProductLocations { get; set; } = new HashSet<ProductLocation>();
        public ICollection<ProductCondition> ProductConditions { get; set; } = new HashSet<ProductCondition>();
        public ICollection<ProductPromotion> ProductPromotions { get; set; } = new HashSet<ProductPromotion>();
        public ICollection<ProductShippingMethod> ProductShippingMethods { get; set; } = new HashSet<ProductShippingMethod>();
        public ICollection<ProductOrder> ProductOrders { get; set; } = new HashSet<ProductOrder>();
        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
    }
}
