using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.Variance
{
    public class VarienceInInterface
    {
        //IEnumerable<out T>(T is covariant)
        //IEnumerator<out T>(T is covariant)
        //IQueryable<out T>(T is covariant)
        //IGrouping<out TKey, out TElement>(TKey and TElement are covariant)
        //IComparer<T>(in T is contravariant)
        //IEqualityComparer<in T>(T is contravariant)
        //IComparable<in T>(T is contravariant)
    }
}
