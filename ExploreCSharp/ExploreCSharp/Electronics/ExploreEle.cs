using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.Electronics
{
    public class ExploreEle
    {
        /// <summary>
        /// To perform swap using EX-OR operator
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Swap(ref int a, ref int b)
        {
            Console.WriteLine($"Before swap: A{a} B:{b}");
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine($"After swap: A:{a} B:{b}");
        }
    }
}
