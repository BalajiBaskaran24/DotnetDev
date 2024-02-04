using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static List<string> products = new List<string> { "Laptop", "Smartphone", "Tablet" };

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return products;
        }

        // Add more CRUD operations here...
    }
}
