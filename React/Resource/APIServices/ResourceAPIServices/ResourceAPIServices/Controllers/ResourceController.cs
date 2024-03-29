using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using ResourceAppLayer;

namespace ResourceAPIServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResourceController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ResourceController> _logger;
        IServiceEngine Services;

        public ResourceController(ILogger<ResourceController> logger, IServiceEngine services)
        {
            _logger = logger;
            Services = services;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPut(Name = "PutQuestion")]
        public bool PutQuestion(Question ques)
        {

            //Working
            //Services.DataFetchService.InsertQuestion_New("MVC", "Model",
            //     "Role of model in MVC",
            //     " Responsible for managing the business logic, data retrieval, data storage, and the overall data handling aspects");


            Services.DataFetchService.InsertQuestion_NewSection_Async(new MongoDB.Bson.ObjectId("660586a3fc7f97a267b1fcce"), "View",
                "Role of view", "To render the data");

            return false;
        }
    }
}
