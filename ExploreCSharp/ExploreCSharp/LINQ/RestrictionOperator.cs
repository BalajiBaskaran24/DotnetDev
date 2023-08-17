using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.LINQ
{
    /// <summary>
    /// Use where keyword or method to get include the constraint
    /// </summary>
    public class RestrictionOperator
    {

        public static void Usage()
        {
            List<string> list = new List<string>() { "abvc", "wrerg", "etrgrt" };

            //Approach 1
            IEnumerable<string> data = list.Where(x => x.Length % 2 == 0);

            //Approach 2
            Func<string,bool> Predicate= x => x.Length % 2 == 0;
            list.Where(Predicate);

            //Approach 3
            list.Where(x => Helper(x));
        }

        public static bool Helper(string input)
        {
            return input.Length % 2 == 0;
        }


    }
}
