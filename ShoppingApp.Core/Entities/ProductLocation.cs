namespace ShoppingApp.Core.Entities
{
    public class ProductLocation
    {
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int LocationId { get; set; }
        public Location? Location { get; set; }
    }
}
