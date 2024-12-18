namespace ShoppingApp.API.DTOs
{
    public class ProductDTO
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public string BrandName { get; set; } = string.Empty;
        public string Condition { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Promotion { get; set; } = string.Empty;
        public string ShippingMethod { get; set; } = string.Empty;
        public string Rating { get; set; } = string.Empty;
        public string ShopType { get; set; } = string.Empty;



        //public ICollection<ProductLocation> ProductLocations { get; set; } = new HashSet<ProductLocation>();
        //public ICollection<ProductCondition> ProductConditions { get; set; } = new HashSet<ProductCondition>();
        //public ICollection<ProductPromotion> ProductPromotions { get; set; } = new HashSet<ProductPromotion>();
        //public ICollection<ProductShippingMethod> ProductShippingMethods { get; set; } = new HashSet<ProductShippingMethod>();
        //public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
    }
}
