using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using ResourceAppLayer;

namespace ResourceAPIServices.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
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

        [HttpPut(Name = "PutQuestion")]
        public bool PutQuestion(Question ques)
        {

            //Working
            //Services.DataFetchService.InsertQuestion_New("MVC", "Model",
            //     "Role of model in MVC",
            //     " Responsible for managing the business logic, data retrieval, data storage, and the overall data handling aspects");


            //Services.DataFetchService.InsertQuestion_NewSection_Async(new MongoDB.Bson.ObjectId("660586a3fc7f97a267b1fcce"), "View",
            //"Role of view", "To render the data");

            return false;
        }

    }
    //public class LocalQues
    //{
    //    public string Ques { get; set; }
    //    public string Answer { get; set; }
    //}
}
