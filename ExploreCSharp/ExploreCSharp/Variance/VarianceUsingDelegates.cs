using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.Variance
{
    /// <summary>
    /// Covariant (out keyword) - Assigning derived to base. 
    /// Generally used for output types
    /// 
    /// Contravariant (in keyword) - Assigning base to derived
    /// Generally used for input types
    /// 
    /// Invarience - Neither covarience nor contravarience
    /// 
    /// EXPLAINS DELEGATE USAGE
    /// </summary>
    public class VarianceUsingDelegates
    {
        public void Starter()
        {
            //Covariance 
            IEnumerable<string> strings = new List<string>();
            IEnumerable<object> objects = strings;
            //Contravariance 
            static void SetObject(object o) { }
            Action<object> actObject = SetObject;
            Action<string> actString = actObject;
        }
        public static void PrintLength(object obj)
        {
            // Contravariant usage, accepting more base type
            if (obj is string str)
            {
                Console.WriteLine($"Length: {str.Length}");
            }
        }

        //Contravarient: Assigning object to string
        ContravariantDelegate<string> contravariantDelegate = new ContravariantDelegate<object>(PrintLength);
        public static First ASecondRFirst(Second second)//Matching signature
        { return new First(); }
        public static Second ASecondRSecond(Second second)//The return type is more derived
        { return new Second(); }
        public static First AFirstRFirst(First first)//The argument type is less derived
        { return new First(); }
        public static Second AFirstRSecond(First first)// The return type is more derived and the argument type is less derived.
        { return new Second(); }

        SampleDelegate dNonGeneric = ASecondRFirst;//Assigning a method with a matching signature to a non-generic delegate. No conversion is necessary. 

        SampleDelegate dNonGenericConversion = AFirstRSecond;//Assign Method with a more derived return and less derived argument to a non-generic delegate. The implicit conversion is used.

        // Assigning a method with a matching signature to a generic delegate.  
        // No conversion is necessary.  
        SampleGenericDelegate<Second, First> dGeneric = ASecondRFirst;

        // Assigning a method with a more derived return type
        // and less derived argument type to a generic delegate.  
        // The implicit conversion is used.  
        SampleGenericDelegate<Second, First> dGenericConversion = AFirstRSecond;

        /// <summary>
        /// This can be assigned to KeyEventHandler->KeyEventArgs , MouseEventHandler->MouseEventArgs
        /// Example of contravarience
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultiHandler(object sender, EventArgs e)
        {
            //Code
        }
    }

    public delegate void ContravariantDelegate<in T>(T item);

    public class First { }
    public class Second : First { }
    public delegate First SampleDelegate(Second a);
    public delegate R SampleGenericDelegate<A, R>(A a);

}
