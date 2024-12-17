using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Core.Entities
{
    public class Condition
    {
        public int Id { get; set; }

        [MaxLength(255), Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<ProductCondition> ProductConditions { get; set; } = [];
    }
}
