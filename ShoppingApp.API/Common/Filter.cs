namespace ShoppingApp.API.Common
{
    public class Filter
    {
        public int Current { get; set; } = 0;
        public int PerPage { get; set; } = 10;
        public string? Search { get; set; } = null;
        public string? SortBy { get; set; } = null;
        public string? SortDir { get; set; } = null;
        public bool IsAsc => string.Equals(SortDir, "asc", StringComparison.OrdinalIgnoreCase);

        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public int? ShopTypeId { get; set; }
        public int? LocationId { get; set; }
        public int? PromotionId { get; set; }
        public int? ConditionId { get; set; }
        public int? ShippingMethodId { get; set; }
        public int? Rating { get; set; }

        public int TotalPages(int totalItems) => (int)Math.Ceiling((double)totalItems / PerPage);


        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
    }
}
