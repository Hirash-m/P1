using Application.constracture.Product;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ConfApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductApplication _productService;

        public ProductController(IProductApplication productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductView>> GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

     [HttpPost]
public ActionResult<ProductView> CreateProduct([FromBody] ProductView productView)
{
    if (productView == null)
    {
        return BadRequest("Product cannot be null.");
    }

    _productService.CreateProduct(productView);
    return Ok(); // فقط یک پاسخ OK برمی‌گرداند
}
    }
}
