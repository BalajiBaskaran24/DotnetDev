using Autofac;
using ExploreCSharp.DesignPatterns.Creational.Singleton;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace Explore.Test.DesignPatterns.Creational.Singleton;

[TestFixture]
public class TestSingleton
{
    /// <summary>
    /// Tests that no new instance is created everytime
    /// </summary>
    [Test]
    public void IsSingletonTest()
    {
        var db = SingletonDatabase.Instance;
        var db2 = SingletonDatabase.Instance;
        Assert.That(db, Is.SameAs(db2));
        Assert.That(SingletonDatabase.Count, Is.EqualTo(1));
    }

    /// <summary>
    /// Access singleton instance directly inside TotalPopulation method
    /// </summary>
    [Test]
    public void SingletonTotalPopulationTest()
    {
        // testing on a live database
        var rf = new SingletonRecordFinder();
        var names = new[] { "Seoul", "Mexico City" };
        int tp = rf.TotalPopulation(names);
        Assert.That(tp, Is.EqualTo(17500000 + 17400000));
    }

    /// <summary>
    /// Takes DB as ctor param
    /// </summary>
    [Test]
    public void DependantTotalPopulationTest()
    {
        var db = new DummyDatabase();
        var rf = new ConfigurableRecordFinder(db);
        Assert.That(
          rf.GetTotalPopulation(new[] { "alpha", "gamma" }),
          Is.EqualTo(4));
    }

    /// <summary>
    /// Uses Autofac to resolve ctor params
    /// </summary>
    [Test]
    public void DIPopulationTest()
    {
        //Configuration part. Instantiation will not happen here
        var cb = new ContainerBuilder();
        cb.RegisterType<OrdinaryDatabase>().As<IDatabase>().
            SingleInstance();//Call this method to register this type as singleton
        cb.RegisterType<ConfigurableRecordFinder>();
        //-------------------------------------------------------


        //Usage
        using (var cbBuild = cb.Build())
        {
            //ConfigurableRecordFinder takes IDatabase as ctor parameter. Below statement will create instance of 
            //OrdinaryDatabase and pass it to ConfigurableRecordFinder ctor
            ConfigurableRecordFinder recfinder = cbBuild.Resolve<ConfigurableRecordFinder>();

            int TotalPopulation = recfinder.GetTotalPopulation(new List<string> { "Osaka" });
        }

    }
}