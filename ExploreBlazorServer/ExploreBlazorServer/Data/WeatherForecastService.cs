namespace ExploreBlazorServer.Data
{
    public class WeatherForecastService
    {
        //private readonly IDummyData _DummyData;
        private readonly DummyData _DummyDataClass;
        private readonly ILogger<WeatherForecastService> log;
        private readonly ILogger logNonGeneric;

        //public WeatherForecastService(IDummyData dummyData)
        //{
        //    _DummyData = dummyData;
        //}
        //public WeatherForecastService(DummyData dataClass, ILogger<WeatherForecastService> log)
        //{
        //    _DummyDataClass = dataClass;
        //    this.log = log;
        //}

        public WeatherForecastService(DummyData dataClass, ILoggerFactory logFact)
        {
            _DummyDataClass = dataClass;
            this.logNonGeneric = logFact.CreateLogger("UserDefinedLog");
        }

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
        {
            //log.LogInformation("Get forecast invoked");
            logNonGeneric.LogInformation("Get forecast invoked");
            return Task.FromResult(Enumerable.Range(1, _DummyDataClass.GetUserAge()).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}