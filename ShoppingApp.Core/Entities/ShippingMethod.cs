namespace ShoppingApp.Core.Entities
{
    public class ShippingMethod
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<ProductShippingMethod> ProductShippingMethods { get; set; } = new HashSet<ProductShippingMethod>();
    }
}
