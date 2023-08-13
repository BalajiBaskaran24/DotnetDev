using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.Electronics
{
    public class Explore
    {
        public static void Swap(int a, int b)
        {
            Console.WriteLine($"Before swap: A{a} B:{b}");
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine($"After swap: A:{a} B:{b}");
        }
    }
}
