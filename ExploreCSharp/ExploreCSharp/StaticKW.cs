using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    public class StaticKW
    {
        //static: Belongs to the type itself rather than to a specific object
        //Variables local to method cannot be static. Because
        //the scope of static variable is different whereas scope
        //of local variables is different. So this cannot be acieved.
        //But in C its doable

        //----------------------------Assign before initialize Static vs reference variables---------------------------------
        static int St1 = St2;//This will not throw error
        static int St2 = 10;

        //St1 holds 0
        //St2 holds 10
        //St1 = 15;
        //Now St1 will have 15

        //int Ref1 = Ref2;//This line throw error
        //int Ref2;
        //-----------------------------------------------------------------

        //------------------------------using static for namespaces-----------------------------------
        //Access static members and nested types
        //without specifying a type name.

        //using static System.Console;
        //using static System.Math;
        //class Program
        //{
        //    static void Main()
        //    {
        //        WriteLine(Sqrt(3 * 3 + 4 * 4));//Instead of Math.Sqrt
        //        }
        //}
        //-----------------------------------------------------------------

        //--------------------------------using static for enum---------------------------------
        //using static Color;
        //enum Color
        //{
        //    Red,
        //    Green,
        //    Blue
        //}
        //class Program
        //{
        //    public static void Main()
        //    {
        //        Color color = Green;//Instead of Color.Green
        //    }
        //}

}


}
