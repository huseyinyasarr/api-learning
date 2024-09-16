using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger) //dependency inject yöntemi
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            var product = new List<Product>() {
                new Product() {Id=1, ProductName="Computer"},
                new Product() {Id=2, ProductName="Keyboard"},
                new Product() {Id=3, ProductName="MouseEventArgs"}
            };
            _logger.LogInformation("Başarılı");
            return Ok(product);           
        }

        [HttpPost]
        public IActionResult GetAllProducts([FromBody] Product product)
        {
            _logger.LogWarning("Product has been created.");
            return StatusCode(201); // Created.
        }

    }
}
