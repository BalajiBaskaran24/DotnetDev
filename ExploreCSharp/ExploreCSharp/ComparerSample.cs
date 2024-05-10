using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace ExploreCSharp
{
    class SampleCmpClass
    {
        int IntData;
        string StringData;

        public SampleCmpClass(int i, string st)
        {
            IntData = i;
            StringData = st;
        }
    }

    internal class ComparerSample
    {
        public static void Starter()
        {
            Type type = typeof(SampleCmpClass);
            // Testing with different types, including nulls
            Console.WriteLine(CompareValues(5, 10));          // Output: -1 GenericComparer<T> : Comparer<T> where T : IComparable<T>?
            Console.WriteLine(CompareValues("apple", "banana"));  // Output: -1
            Console.WriteLine(CompareValues(3.5, 2.5));       // Output: 1
            Console.WriteLine(CompareValues(true, false));    // Output: 1
            Console.WriteLine(CompareValues<int?>(null, 5));  // Output: -1
            Console.WriteLine(CompareValues<string>("apple", null));  // Output: 1
            Console.WriteLine(CompareValues<string>(null, null));  // Output: 0
            Console.WriteLine(CompareValues(new SampleCmpClass(1, "one"), new SampleCmpClass(2, "two")));//ObjectComparer
        }

        /// <summary>
        /// Compares two values of any type using a generic comparison operator.
        /// </summary>
        /// <typeparam name="T">Type of the values to compare</typeparam>
        /// <param name="a">First value</param>
        /// <param name="b">Second value</param>
        /// <returns>
        /// -1 if `a` is less than `b`,
        ///  1 if `a` is greater than `b`,
        ///  0 if both values are equal.
        /// </returns>
        public static int CompareValues<T>(T a, T b)
        {
            if (ReferenceEquals(a, b))
                return 0;
            if (a == null)
                return -1;
            if (b == null)
                return 1;

            return Comparer<T>.Default.Compare(a, b);
        }
    }


}
