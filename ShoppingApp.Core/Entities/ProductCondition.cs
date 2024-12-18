namespace ShoppingApp.Core.Entities
{
    public class ProductCondition
    {
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int ConditionId { get; set; }
        public Condition? Condition { get; set; }
    }
}
