namespace ShoppingApp.Core.Entities
{
    public class ProductCondition
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();

        public int ConditionId { get; set; }
        public Condition Condition { get; set; } = new Condition();
    }
}
