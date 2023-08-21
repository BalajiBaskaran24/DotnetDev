namespace ExploreBlazorServer.Data
{
    public class DummyData //: IDummyData
    {
        private int Age;
        public DummyData()
        {
            Random rnd = new Random();
            Age = rnd.Next(1, 10);
        }

        public int GetUserAge()
        {
            return Age;
        }
    }
}
