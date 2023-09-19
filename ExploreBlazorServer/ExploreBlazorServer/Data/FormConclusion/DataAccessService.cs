namespace ExploreBlazorServer.Data.FormConclusion
{
    public class DataAccessService : IDataAccessService
    {
        public List<string> GetMSType()
        {
            return new List<string>()
            {
                "Chocolate",
                "Vanilla",
                "Peanut butter",
                "Strawberry"
            };
        }

        public List<string> GetMSSize()
        {
            return new List<string>()
            {
                "Regular",
                "Medium",
                "Large",
                "Extra Large"
            };
        }
    }
}
