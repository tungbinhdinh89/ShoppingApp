using Microsoft.AspNetCore.Mvc;
using ShoppingApp.API.Common;
using ShoppingApp.API.Services;

namespace ShoppingApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController(IProductServices productServices) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery] Filter filter)
        {
            var list = await productServices.GetProducts(filter ?? new());
            return Ok(list);
        }
    }
}
