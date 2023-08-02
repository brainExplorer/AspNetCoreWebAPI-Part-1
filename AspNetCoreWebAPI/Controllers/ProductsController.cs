using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreWebAPI.Models;

namespace AspNetCoreWebAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
                _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllProducts() 
        {
            var products = new List<Product>()
            {
                new Product { Id = 1,ProductName="computer"},
                new Product { Id = 2,ProductName="Mouse"},
                new Product { Id = 3,ProductName="Keyboard"}
            };
            _logger.LogInformation("GetAllProducts action has been called.");
            return Ok(products);
        }

        [HttpPost]
        public IActionResult GetAllProducts(Product product )
        {
            _logger.LogWarning("Product has been created");
            return StatusCode(201); // created
        }

    }
}
