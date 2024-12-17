namespace ShoppingApp.Core.Entities
{
    public class ProductPromotion
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();

        public int PromotionId { get; set; }
        public Promotion Promotion { get; set; } = new Promotion();
    }
}
