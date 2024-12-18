using Microsoft.EntityFrameworkCore;
using ShoppingApp.API.Common;
using ShoppingApp.API.DTOs;
using ShoppingApp.API.Extensions;
using ShoppingApp.API.Services;
using ShoppingApp.Core.DB;
using ShoppingApp.Core.Entities;

namespace ShoppingApp.API.Implementation
{
    public class ProductServices(ApplicationDbContext dbContext) : IProductServices
    {
        public async Task<Paging<ProductDTO>> GetProducts(Filter filter)
        {
            filter ??= new();

            var current = filter.Current;
            var take = filter.PerPage;
            var query = dbContext.Products
                                       .Include(p => p.Brand)
                                       .Include(p => p.SubCategory!)
                                       .ThenInclude(s => s.Category)
                                       .Include(p => p.ShopType)
                                       .Include(p => p.ProductConditions)
                                       .Include(p => p.ProductLocations)
                                       .Include(p => p.ProductShippingMethods)
                                       .Include(p => p.ProductPromotions)
                                       .Include(p => p.ProductOrders)
                                       .OrderByDescending(x => x.Id)
                                       .AsNoTracking()
                                       .AsQueryable();

            // filter by category
            if (filter.CategoryId.HasValue)
            {
                query = query.Where(p => p.SubCategory!.CategoryId == filter.CategoryId.Value);
            }

            // filter by subcategory
            if (filter.SubCategoryId.HasValue)
            {
                query = query.Where(p => p.SubCategoryId == filter.SubCategoryId.Value);
            }

            // filter by location
            if (filter.LocationId.HasValue)
            {
                query = query.Where(x => x.ProductLocations.Any(l => l.LocationId == filter.LocationId.Value));
            }

            // filter by shipping method
            if (filter.ShippingMethodId.HasValue)
            {
                query = query.Where(x => x.ProductShippingMethods.Any(ps => ps.ShippingMethodId == filter.ShippingMethodId.Value));
            }

            // filter by brand
            if (filter.BrandId.HasValue)
            {
                query = query.Where(x => x.BrandId == filter.BrandId.Value);
            }

            // filter by price
            if (filter.MinPrice.HasValue && filter.MaxPrice.HasValue)
            {
                query = query.Where(x => x.Price > filter.MinPrice.Value && x.Price < filter.MaxPrice.Value);
            }

            // filter by shop type
            if (filter.ShopTypeId.HasValue)
            {
                query = query.Where(x => x.ShopTypeId == filter.ShopTypeId.Value);
            }

            // filter by condition
            if (filter.ConditionId.HasValue)
            {
                query = query.Where(x => x.ProductConditions.Any(c => c.ConditionId == filter.ConditionId.Value));
            }

            // filter by rating
            if (filter.Rating.HasValue)
            {
                query = query.Where(x => x.Reviews.Any(r => r.Rating == filter.Rating.Value.ToString()));
            }

            // filter by promotion
            if (filter.PromotionId.HasValue)
            {
                query = query.Where(x => x.ProductPromotions.Any(pp => pp.PromotionId == filter.PromotionId.Value));
            }

            // search
            if (!string.IsNullOrWhiteSpace(filter.Search))
            {
                var q = filter.Search.Trim().ToLower();
                query = query.Where(x => x.Name.Contains(q));
            }

            // sort
            if (!string.IsNullOrWhiteSpace(filter.SortBy))
            {
                var sort = filter.SortBy.Trim();
                query = sort switch
                {
                    nameof(Product.ViewCount) => query.Sort(x => x.ViewCount, filter.IsAsc),
                    nameof(Product.SoldCount) => query.Sort(x => x.SoldCount, filter.IsAsc),
                    nameof(Product.CreatedDate) => query.Sort(x => x.CreatedDate, filter.IsAsc),
                    nameof(Product.Price) => query.Sort(x => x.Price, filter.IsAsc),
                    _ => query
                };
            }

            var totalItems = await query.CountAsync();

            var paging = await query.ToPagingAsync(p => new ProductDTO
            {
                Name = p.Name,
                Price = p.Price,
                ShopType = p.ShopType!.Name ?? string.Empty,
                BrandName = p.Brand!.Name ?? string.Empty,
                Location = p.ProductLocations.Select(pl => pl.Location!.Name).FirstOrDefault() ?? string.Empty,
                Condition = p.ProductConditions.Select(pc => pc.Condition!.Name).FirstOrDefault() ?? string.Empty,
                Promotion = p.ProductPromotions.Select(pp => pp.Promotion!.Name).FirstOrDefault() ?? string.Empty,
                ShippingMethod = p.ProductShippingMethods.Select(ps => ps.ShippingMethod!.Name).FirstOrDefault() ?? string.Empty,
                Rating = p.Reviews.Select(p => p.Rating).FirstOrDefault() ?? string.Empty,
            }, current, take);

            return new Paging<ProductDTO>(paging.Items, totalItems, filter.Current);
        }
    }
}
