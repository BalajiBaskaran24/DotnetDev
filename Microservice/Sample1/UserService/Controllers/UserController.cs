using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace UserService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static List<string> users = new List<string> { "Alice", "Bob", "Charlie" };

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return users;
        }

        // Add user management logic...
    }
}
