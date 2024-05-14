using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{


    internal class ImmutableandReadOnlyCollection
    {
        //static readonly IReadOnlyList<int> SampleList = new[] { 1, 2, 3 };
        static List<int> SampleList = new() { 1, 2, 3 };
        void Starter()
        {
            //Change the list to readonly to block the below initialization
            SampleList = new List<int> { 4, 5, 6 };


            //Change the list to immutablelist to block the below assignment
            SampleList[0] = 1;

            //Change the list to readonly ireadonlylist to block the below assignment
            SampleList.Add(2);
            SampleList.Remove(1);
        }

    }
}
