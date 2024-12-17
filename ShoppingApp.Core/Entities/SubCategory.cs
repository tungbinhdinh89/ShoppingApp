using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Core.Entities
{
    public class SubCategory
    {
        public int Id { get; set; }

        [MaxLength(255), Required]
        public string Name { get; set; } = string.Empty;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = new Category();

        public ICollection<Product> Products { get; set; } = [];
    }
}
