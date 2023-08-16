using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    public class Delegates
    {

        public void DefaultDelUsage()
        {
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            // Define the Func<TSource, int, bool> predicate
            Func<string, int, bool> predicate = (fruit, index) => fruit.Length > 5 && index % 2 == 0;

            // Use the predicate with LINQ's Where method
            var filteredFruits = fruits.Where(predicate);

        }
    }
}
