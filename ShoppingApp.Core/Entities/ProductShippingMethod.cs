namespace ShoppingApp.Core.Entities
{
    public class ProductShippingMethod
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();

        public int ShippingMethodId { get; set; }
        public ShippingMethod ShippingMethod { get; set; } = new ShippingMethod();
    }
}
