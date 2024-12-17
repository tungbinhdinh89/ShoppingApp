using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Core.Entities
{
    public class Brand
    {
        public int Id { get; set; }

        [MaxLength(255), Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<Product> Products { get; set; } = [];
    }
}
