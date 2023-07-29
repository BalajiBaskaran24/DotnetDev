using Dapper;
using Microsoft.Extensions.Configuration;
using Serilog;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.DbAccess;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _configuration;

    public SqlDataAccess(IConfiguration configuration)
    {
        this._configuration = configuration;
    }

    public async Task<IEnumerable<T>> LoadData<T, U>(
        string storedProcedure,
        U parameters,
        string connectionId = "Default")
    {
        Log.Write(Serilog.Events.LogEventLevel.Error, "Entered load data");
        string? connString = _configuration.GetConnectionString(connectionId);
        IDbConnection connection = new SqlConnection();
        try
        {
            connection = new SqlConnection(connString);

        }
        catch (Exception ex)
        {

        }
        return await connection.QueryAsync<T>(storedProcedure, parameters,
                commandType: CommandType.StoredProcedure);

    }

    public async Task SaveData<T>(
       string storedProcedure,
       T parameters,
       string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionId));

        await connection.ExecuteAsync(storedProcedure, parameters,
            commandType: CommandType.StoredProcedure);
    }
}
