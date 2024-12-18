using ShoppingApp.API.Common;
using ShoppingApp.API.DTOs;

namespace ShoppingApp.API.Services
{
    public interface IProductServices
    {
        Task<Paging<ProductDTO>> GetProducts(Filter filter);
    }
}
