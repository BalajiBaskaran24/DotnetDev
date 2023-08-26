namespace ExploreBlazorServer.Data
{
    public class CounterService : ICounterService
    {
        public int CounterValue { get; private set; }
        public CounterService(ILogger<CounterService> logger)
        {
            Logger = logger;
        }

        public ILogger<CounterService> Logger { get; }

        public void IncrementCounter()
        {
            CounterValue++;
        }
    }
}
