using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.Events;


public class EventUsage
{
    /// <summary>
    /// Start method for EventHandler understanding
    /// </summary>
    static void Starter()
    {
        CounterSample c = new CounterSample(new Random().Next(10));
        c.ThresholdReached += c_ThresholdReached;

        Console.WriteLine("press 'a' key to increase total");
        while (Console.ReadKey(true).KeyChar == 'a')
        {
            Console.WriteLine("adding one");
            c.Add(1);
        }
    }

    /// <summary>
    /// Method binded to event present in CounterSample
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
    {
        Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
        Environment.Exit(0);
    }
}


/// <summary>
/// Sample class with EventHandler<Type> delegate reference
/// </summary>
public class CounterSample
{
    private int threshold;
    private int total;

    public CounterSample(int passedThreshold)
    {
        threshold = passedThreshold;
    }

    public void Add(int x)
    {
        total += x;
        if (total >= threshold)
        {
            ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
            args.Threshold = threshold;
            args.TimeReached = DateTime.Now;
            OnThresholdReached(args);
        }
    }

    protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
    {
        EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
        if (handler != null)
        {
            handler(this, e);
        }
    }

    /// <summary>
    /// Event of delegate type EventHandler<Type>
    /// </summary>
    public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
}

/// <summary>
/// Event argument
/// </summary>
public class ThresholdReachedEventArgs : EventArgs
{
    public int Threshold { get; set; }
    public DateTime TimeReached { get; set; }
}
