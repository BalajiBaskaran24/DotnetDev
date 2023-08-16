using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    /// <summary>
    /// Class contains extension method
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// First parameter will have "this" keyword. This indicates its a extension method.
        /// </summary>
        /// <param name="extClass"></param>
        /// <param name="input"></param>
        public static void ExtMethod(this SampleForExt extClass, int input)
        {

        }

        //This will throw error. Method should be static
        //public void ExtMethodDup(this SampleForExt extClass, int input){}
    }

    /// <summary>
    /// Class for which extension method is written
    /// </summary>
    public class SampleForExt
    {

    }

    /// <summary>
    /// Class that uses extension
    /// </summary>
    public class ExtensionUsage
    {
        public void ExtUsage()
        {
            SampleForExt ext = new SampleForExt();
            ext.ExtMethod(0);
        }
    }

}
