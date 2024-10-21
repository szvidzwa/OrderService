using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Models;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private static readonly List<Order> Orders = new();

        [HttpPost]
        public ActionResult<Order> CreateOrder([FromBody] Order order)
        {
            if (order == null || string.IsNullOrWhiteSpace(order.CustomerName) || !order.Products.Any())
            {
                return BadRequest("Invalid order data.");
            }

            order.OrderId = Orders.Count + 1;
            order.OrderDate = DateTime.Now;
            Orders.Add(order);
            return CreatedAtAction(nameof(CreateOrder), order);
        }
    }
}
