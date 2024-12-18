namespace ShoppingApp.Core.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public ICollection<SubCategory> SubCategories { get; set; } = new HashSet<SubCategory>();
    }
}
