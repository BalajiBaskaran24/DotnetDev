using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Diagnostics.Tracing.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.DesignPatterns.Creational.Factory.DimitrySample;

/// <summary>
/// Access, create and use various factories and modules
/// </summary>
public class Launcher
{
    private List<Tuple<string, IWirelessModulesFactory>> factories =
        new List<Tuple<string, IWirelessModulesFactory>>();
    public void LaunchApp()
    {
        string targetNamespace = "ExploreCSharp.DesignPatterns.Creational.Factory.DimitrySample";

        // Get all types in the current assembly
        Type[] allTypes = Assembly.GetExecutingAssembly().GetTypes();

        // Filter types by namespace
        var typesInNamespace = allTypes
            .Where(type => type.Namespace == targetNamespace)
            .ToList();


        //Instantiate all factories
        foreach (var t in typesInNamespace)
        {
            if (typeof(IWirelessModulesFactory).IsAssignableFrom(t) &&
                    !t.IsInterface)
            {
                factories.Add(Tuple.Create
                    (t.Name.Replace("Factory", string.Empty)
                    , (IWirelessModulesFactory)Activator.CreateInstance(t)));
            }
        }

        ListAvailableModules();
        GetRequiredFactory(0);
    }

    public void ListAvailableModules()
    {
        Console.WriteLine("Available modules");
        foreach (var module in factories)
        {
            Console.WriteLine($"{module.Item1} {module.Item2}");
        }
    }

    /// <summary>
    /// Access the factories list and call appropriate factory and instantiate the model
    /// </summary>
    /// <param name="moduleIndex"></param>
    /// <returns></returns>
    public IWirelessModules GetRequiredFactory(int moduleIndex)
    {
        Console.WriteLine($"User selected index: {moduleIndex}");
        return factories[moduleIndex].Item2.CreateWirelessModule();
    }

}
