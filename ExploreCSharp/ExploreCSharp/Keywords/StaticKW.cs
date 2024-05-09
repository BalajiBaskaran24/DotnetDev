using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.Keywords
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

        static int St3 = St4;
        static int St4;

        //St1 holds 0
        //St2 holds 10
        //St1 = 15;
        //Now St1 will have 15
        int Ref2 = 0;
        //int Ref1 = Ref2;//This line throw error
        //int Ref2 = 0;
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


        //public void StaticLocalMember()
        //{
        //    static int StaticLocalVariable = 1;//This will throw error
        //}

    }

    /// <summary>
    /// If the static keyword is applied to a class, all the members of the class must be static.
    /// </summary>
    public static class SampleStaticClass
    {
        //public int a = 10;//CS0708:: This error occurs if you declare a non-static member in a class that is declared static

        //public void SampleMethod() //CS0708
        //{
        //
        //}
    }

    class StaticInitialization
    {
        /// <summary>
        /// you can initialize a static field by using another static field 
        /// that is not yet declared.The results will be undefined until you explicitly 
        /// assign a value to the static field.
        /// </summary>
        static int x = y;

        static int y = 5;

        public static void StaticVarInit()
        {
            Console.WriteLine(StaticInitialization.x);
            Console.WriteLine(StaticInitialization.y);

            StaticInitialization.x = 99;
            Console.WriteLine(StaticInitialization.x);
        }
    }
    /*
    Output:
        0
        5
        99
    */

    public class NonStaticClass
    {
        public static int StaticVariable;

        public void NonstaticMethod()
        {
            StaticVariable++;
            NonStaticVariable++;
        }

        public int NonStaticVariable;

        public static void StaticMethod()
        {
            //NonStaticVariable++;//CS0120 Object reference is required
        }

    }


    public class StaticStarter
    {
        public static void Start()
        {
            StaticInitialization.StaticVarInit();
        }
    }

}
