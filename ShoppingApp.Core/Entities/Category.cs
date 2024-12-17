using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Core.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(255), Required]
        public string Name { get; set; } = String.Empty;

        public ICollection<SubCategory> SubCategories { get; set; } = [];
    }
}
