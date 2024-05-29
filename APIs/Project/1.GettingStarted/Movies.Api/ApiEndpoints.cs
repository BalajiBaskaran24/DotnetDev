
using Microsoft.Data.SqlClient;

namespace Movies.Api;

public static class ApiEndpoints
{
    private const string ApiBase = "api";

    public static class Movies
    {
        private const string Base = $"{ApiBase}/movies";

        public const string Create = Base;
        public const string Get = $"{Base}/{{id:guid}}";
        public const string GetAll = Base;
        public const string Update = $"{Base}/{{id:guid}}";
        public const string Delete = $"{Base}/{{id:guid}}";
    }

    private static void ReadOrderData(string connectionString)
    {
        string queryString =
            "SELECT OrderID, CustomerID FROM dbo.Orders;";
        using (SqlConnection connection = new SqlConnection(
                   connectionString))
        {
            SqlCommand command = new SqlCommand(
                queryString, connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}, {1}",
                        reader[0], reader[1]));
                }
            }
        }
    }
}
