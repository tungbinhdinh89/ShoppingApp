namespace ShoppingApp.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Quantity { get; set; } = 0;
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        public ICollection<ProductOrder> ProductOrders { get; set; } = new HashSet<ProductOrder>();
    }
}
