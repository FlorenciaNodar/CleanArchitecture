using DemoCleanArchitecture.Application.Services;
using DemoCleanArchitecture.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoCleanArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
        
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            return _productService.Get(id);
        }

        [HttpPost()]
        public ActionResult<Product> Post(Product product)
        {
            _productService.Post(product);

            return product;
        }

    }
}
