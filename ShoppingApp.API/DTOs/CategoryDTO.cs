namespace ShoppingApp.API.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<SubCategoryDto> SubCategories { get; set; } = new HashSet<SubCategoryDto>();
    }
}
