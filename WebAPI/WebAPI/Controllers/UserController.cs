using Microsoft.AspNetCore.Mvc;
namespace WebAPI.Controllers;

//To perform
//Create Read Update Delete below verbs will be used

//GET - Client gets the data from http server
//POST - Creates new record
//PUT - Updates whole record (or possibly creates)
//PATCH - Updates part of record
//DELETE - Deletes record

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    public IConfiguration Configuration { get; }

    private readonly ILogger<UserController> _logger;
    public UserController(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    
    //// GET: api/Users/GetAllUser
    //[HttpGet("GetAllUser")]//Decorator

    // GET: api/Users/
    [HttpGet()]//Decorator
    public string Get()
    {
        return Configuration.GetConnectionString("Default");
    }

    // GET api/Users/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/Users
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/Users/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/Users/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
