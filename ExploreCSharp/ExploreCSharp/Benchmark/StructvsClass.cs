using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExploreCSharp.Benchmark
{
    [MemoryDiagnoser(false)]
    public class StructvsClass
    {
        [GlobalSetup]
        public void Setup()
        {

        }

        [Benchmark]
        public void InitClass()
        {
            SampleClass sampleClass = new SampleClass();
        }

        [Benchmark]
        public void InitStruct()
        {
            SampleStruct St = new SampleStruct();
        }
    }


    public struct SampleStruct
    {
        public long L1, L2, L3, L4, L5, L6, L7, L8;
        public long L9, L10, L11, L12, L13;
    }

    public class SampleClass
    {
        public long L1, L2, L3, L4, L5, L6, L7, L8;
        public long L9, L10, L11, L12, L13;
    }
}
