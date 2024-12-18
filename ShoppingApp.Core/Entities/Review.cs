namespace ShoppingApp.Core.Entities
{
    public class Review
    {
        public int Id { get; set; }

        public string Rating { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
