using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Models;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> Products = new()
    {
        new Product { Id = 1, Name = "Product1", Price = 10.99m },
        new Product { Id = 2, Name = "Product2", Price = 20.99m }
    };

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(Products);
        }
    }
}
