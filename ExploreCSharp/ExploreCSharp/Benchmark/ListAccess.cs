using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.Benchmark
{
    /// <summary>
    ///| Method              | Mean      | Error     | StdDev    | Allocated |
    ///| AccessingListDirect | 0.2990 ns | 0.0309 ns | 0.0672 ns |         - |
    ///| AssignandAccess     | 0.2482 ns | 0.0282 ns | 0.0366 ns |         - |
    /// </summary>
    [MemoryDiagnoser(false)]
    public class ListAccess
    {
        public List<Data> ObData = null;

        [GlobalSetup]
        public void Setup()
        {
            ObData = new(10000);
        }


        [Benchmark]
        public void AccessingListDirect()
        {
            for (int i = 0; i < ObData.Count; i++)
            {
                ObData[i].L7 = 0;
            }

        }

        [Benchmark]
        public void AssignandAccess()
        {
            for (int i = 0; i < ObData.Count; i++)
            {
                Data Local = ObData[i];
                Local.L7 = 0;
            }
        }
    }


    public class Data
    {
        public long L1, L2, L3, L4, L5, L6, L7, L8;
        public long L9, L10, L11, L12, L13;
    }
}
