namespace ExploreBlazorServer.Data
{
    public interface ICounterService
    {
        int CounterValue { get; }
        ILogger<CounterService> Logger { get; }

        void IncrementCounter();
    }
}