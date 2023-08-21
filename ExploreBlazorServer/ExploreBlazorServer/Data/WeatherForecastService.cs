namespace ExploreBlazorServer.Data
{
    public class WeatherForecastService
    {
        //private readonly IDummyData _DummyData;
        private readonly DummyData _DummyDataClass;
        //public WeatherForecastService(IDummyData dummyData)
        //{
        //    _DummyData = dummyData;
        //}
        public WeatherForecastService(DummyData dataClass)
        {
            _DummyDataClass = dataClass;
        }


        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
        {
            return Task.FromResult(Enumerable.Range(1, _DummyDataClass.GetUserAge()).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}