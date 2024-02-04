using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private static List<string> orders = new List<string>();

        [HttpPost]
        public ActionResult<string> CreateOrder(string product)
        {
            orders.Add(product);
            return Ok($"Order created for {product}");
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return orders;
        }

        // Implement additional order management logic...
    }
}
