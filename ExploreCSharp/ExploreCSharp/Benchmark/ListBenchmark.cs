using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ExploreCSharp.Benchmark;

/// <summary>
/// Benchmarks various technique used to iterate collection
/// ForEach_Span and For_Span iterates faster than For and Foreach
/// </summary>
[MemoryDiagnoser(false)]
public class ListBenchmark
{
    private static readonly Random Rng = new(80085);

    /// <summary>
    /// Benchmark results will be provided for each of this param value
    /// </summary>
    [Params(100, 1000, 10000)]
    public int Size { get; set; } = 100;

    public List<int> _items;

    [GlobalSetup]
    public void Setup()
    {
        _items = Enumerable.Range(1, Size).Select(x => Rng.Next()).ToList();
    }

    [Benchmark]
    public void For()
    {
        for (int i = 0; i < _items.Count; i++)
        {
            var item = _items[i];
        }
    }

    [Benchmark]
    public void Foreach()
    {
        foreach (var item in _items)
        {
            var currItem = item;
        }
    }

    [Benchmark]
    public void ForEach_Span()
    {
        foreach (int item in CollectionsMarshal.AsSpan(_items))//Provides readonly instance.
                                                               //Also collection should not be altered while span is in use
        {
            var currItem = item;
        }
    }

    [Benchmark]
    public void For_Span()
    {
        var asSpan = CollectionsMarshal.AsSpan(_items);
        for (var i = 0; i < asSpan.Length; i++)
        {
            var item = asSpan[i];
        }
    }
}

public class BMStarter
{
    /// <summary>
    /// To run all benchmark
    /// </summary>
    public static void Start()
    {

        //BenchmarkRunner.Run<ListBenchmark>();
        //BenchmarkRunner.Run<ListAccess>();
        BenchmarkRunner.Run<StructvsClass>();
    }
}








