namespace ExploreBlazorServer.Data
{
    public class WeatherForecastService
    {
        //private readonly IDummyData _DummyData;
        private readonly DummyData _DummyDataClass;
        private readonly ILogger<WeatherForecastService> log;
        private readonly ILogger logNonGeneric;


        public WeatherForecastService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //-------------------------Sample for injecting user spcified class-------------------------
        //public WeatherForecastService(IDummyData dummyData)
        //{
        //    _DummyData = dummyData;
        //}
        ////--------------------------------------------------


        //-------------------------Sample for injecting logger service-------------------------
        //public WeatherForecastService(DummyData dataClass, ILogger<WeatherForecastService> log)
        //{
        //    _DummyDataClass = dataClass;
        //    this.log = log;
        //}
        //public WeatherForecastService(DummyData dataClass, ILoggerFactory logFact)
        //{
        //    _DummyDataClass = dataClass;
        //    this.logNonGeneric = logFact.CreateLogger("UserDefinedLog");
        //}
        //------------------------END--------------------------

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        private readonly IConfiguration configuration;

        public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
        {
            //log.LogInformation("Get forecast invoked");
            //logNonGeneric.LogInformation("Get forecast invoked");

            //Sample for accessing the data using dependency injection
            //return Task.FromResult(Enumerable.Range(1, _DummyDataClass.GetUserAge()).Select(index => new WeatherForecast
            //{
            //    Date = startDate.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //}).ToArray());

            //To fetch the data from configuration files -> appsettings.json, appsettings.<Environment>.json
            int DataFromAppsettings = configuration.GetValue<int>("WeatherForecastSample");//Key name is parameter
            int MultiLevelData = configuration.GetValue<int>("Level1:Level2");//Use colon to traverse nested values
            return Task.FromResult(Enumerable.Range(1, DataFromAppsettings).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}