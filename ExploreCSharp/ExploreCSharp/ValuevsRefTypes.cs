using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{

    /// <summary>
    /// Starter class
    /// Keyword: null
    /// The null keyword is a literal that represents a null reference, one that 
    /// does not refer to any object. null is the default value of reference-type variables. 
    /// Ordinary value types cannot be null, except for nullable value types.
    /// </summary>
    public class ValuevsRefTypes
    {
        public static void ValueRefStarter()
        {
            //------------Behavior of reference type(class)---------
            ValueandRef Data1 = new ValueandRef() { Numerical = 1, Str = "One", Integers = new List<int>() { 1 } };
            ValueandRef Data2 = Data1;
            Data2.Numerical = 2;
            Data2.Str = "two";
            Data2.Integers.Add(2);
            Data2.Integers[0] = 2;
            Console.WriteLine(Data1);
            Console.WriteLine(Data2);
            //------------------------------------------------------  


            //------------Behavior of value type(struct)------------
            TaggedInteger n1 = new TaggedInteger(0);
            n1.AddTag("A");
            Console.WriteLine(n1);  // output: 0 [A]
            TaggedInteger n2 = n1;
            n2.Number = 7;
            n2.AddTag("B");
            Console.WriteLine(n1);  // output: 0 [A, B]
            Console.WriteLine(n2);  // output: 7 [A, B]
            //------------------------------------------------------  
        }
    }


    /// <summary>
    /// Keyword: struct (value-type)
    /// If value type contains the reference type member then, only the reference to the 
    /// instance of the reference type is copied when a value-type instance is copied
    /// </summary>
    public struct TaggedInteger
    {
        /// <summary>
        /// Value type behavior
        /// </summary>
        public int Number;

        /// <summary>
        /// Reference type behavior
        /// </summary>
        public List<string> tags;

        public TaggedInteger(int n)
        {
            Number = n;
            tags = new List<string>();
        }

        public void AddTag(string tag) => tags.Add(tag);

        public override string ToString() => $"{Number} [{string.Join(", ", tags)}]";
    }


    public class SampleClass
    {
        public int Temp = 0;
    }

    /// <summary>
    /// Contains value type and one reference type
    /// Reference type behavior for all members
    /// </summary>
    public class ValueandRef
    {
        public int Numerical = 0;
        public string Str = "";
        public List<int> Integers = null;
        public List<string> Strings = null;
        public List<SampleClass> Samples = null;

        public ValueandRef()
        {
            Integers = new List<int>();
            int TempInt = 1;
            Integers.Add(TempInt);
            TempInt = 5;
            string TempStr = "First";
            Strings = new List<string>();
            Strings.Add(TempStr);
            TempStr = "Altered";
            Samples = new List<SampleClass>();
            SampleClass sampleClass = new SampleClass() { Temp = 5 };
            Samples.Add(sampleClass);
            Samples[0].Temp = 10;
            Samples[0] = null;
            //sampleClass = new SampleClass();
        }

        public override string ToString()
        {
            return $"Numerical:{Numerical} Str:{Str} {string.Join(", ", Integers.Select(i => i.ToString()))}";
        }
    }

}
