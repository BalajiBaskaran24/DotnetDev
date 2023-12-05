using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExploreCSharp.DesignPatterns.Creational.Singleton;

public interface IDatabase
{
    int GetPopulation(string name);
}

/// <summary>
/// DB used in testing
/// </summary>
public class DummyDatabase : IDatabase
{
    public int GetPopulation(string name)
    {
        return new Dictionary<string, int>
        {
            ["alpha"] = 1,
            ["beta"] = 2,
            ["gamma"] = 3
        }[name];
    }
}

/// <summary>
/// Provides access to "capitals.txt" file
/// </summary>
public class SingletonDatabase : IDatabase
{
    private Dictionary<string, int> capitals;
    private static int instanceCount;
    public static int Count => instanceCount;

    private SingletonDatabase()
    {
        WriteLine("Initializing database");

        capitals = File.ReadAllLines(
          Path.Combine(
            new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName, "capitals.txt")
          ).Batch(2)
          .ToDictionary(
            list => list.ElementAt(0).Trim(),
            list => int.Parse(list.ElementAt(1)));
    }

    public int GetPopulation(string name)
    {
        return capitals[name];
    }

    /// <summary>
    /// Lazy initilization: Instance for SingletonDatabase is created only when we access instance.Value
    /// </summary>
    private static Lazy<SingletonDatabase> instance = new Lazy<SingletonDatabase>(() =>
    {
        instanceCount++;
        return new SingletonDatabase();
    });

    public static IDatabase Instance => instance.Value;
}

public class OrdinaryDatabase : IDatabase
{
    private Dictionary<string, int> capitals;

    public OrdinaryDatabase()
    {
        WriteLine("Initializing database");

        capitals = File.ReadAllLines(
          Path.Combine(
            new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName, "capitals.txt")
          ).Batch(2)
          .ToDictionary(
            list => list.ElementAt(0).Trim(),
            list => int.Parse(list.ElementAt(1)));
    }
    public int GetPopulation(string name)
    {
        return capitals[name];
    }
}


public class SingletonStarter
{
    public static void Starter()
    {
        var db = SingletonDatabase.Instance;

        // works just fine while you're working with a real database.
        var city = "Tokyo";
        WriteLine($"{city} has population {db.GetPopulation(city)}");

        // now some tests
    }
}


/// <summary>
/// Access Layer: Used singleton instance directly
/// </summary>
public class SingletonRecordFinder
{
    public int TotalPopulation(IEnumerable<string> names)
    {
        int result = 0;
        foreach (var name in names)
            result += SingletonDatabase.Instance.GetPopulation(name);
        return result;
    }
}


/// <summary>
/// Access Layer: Inject DB using DI
/// </summary>
public class ConfigurableRecordFinder
{
    private IDatabase database;

    public ConfigurableRecordFinder(IDatabase database)
    {
        this.database = database;
    }

    public int GetTotalPopulation(IEnumerable<string> names)
    {
        int result = 0;
        foreach (var name in names)
            result += database.GetPopulation(name);
        return result;
    }
}

