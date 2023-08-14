using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.TwoDArray
{
    public class TwoDArray
    {
        public static void Starter2D()
        {
            List<List<int>> _2DLst = new List<List<int>>();
            _2DLst.Add(new List<int>() { 1 });
            _2DLst.Add(new List<int>() { 1, 2 });
            _2DLst.Add(new List<int>() { 1, 2, 3, 4, 5 });
            _2DLst.Add(new List<int>() { 1, 2, 3, 4, 5, 6, 7 });
            Console.WriteLine($"Count of 2D list:{_2DLst.Count}");
        }
    }
}
