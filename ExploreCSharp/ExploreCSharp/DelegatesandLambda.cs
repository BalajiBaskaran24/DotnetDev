using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    public class DelegatesandLambda
    {
        public void DefaultDelUsage()
        {
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
            Func<string, int, bool> predicate = (fruit, index) => fruit.Length > 5 && index % 2 == 0;// Define the Func<TSource, int, bool> predicate
            var filteredFruits = fruits.Where(predicate);// Use the predicate with LINQ's Where method
        }

        //--------------Declaring and using a delegate--------------
        public delegate string Reverse(string s);
        static string ReverseStringDel(string s)
        {
            return new string(s.Reverse().ToArray());
        }
        static void UsageDel()
        {
            Reverse rev = ReverseStringDel;
            Console.WriteLine(rev("a string"));
        }
        //--------------End--------------

        //--------------Using Func--------------
        static string ReverseStringFunc(string s)
        {
            return new string(s.Reverse().ToArray());
        }

        static void UsageFunc()
        {
            Func<string, string> rev = ReverseStringFunc;
            Console.WriteLine(rev("a string"));
        }
        //--------------End--------------
    }
}
