using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.Keywords
{
    /// <summary>
    /// Funcitonality and use of var and dynamic keyword
    /// </summary>
    public class VarDynamic
    {

        //var sample = 0; This will throw error
        //Explanation: We know that the type of var variable will be assinged by evaluating right hand side experession.
        //Class scope variables can be used without initialization, whereas local variables cannot be. So we cannot assure that
        //compiler will always get a chance to evaluate the type of var for class scope varaibles.
        
        static int varClassLevel;
        public static void Usage()
        {
            var a = new SampleClass1();
            //a = new SampleClass2();//This will throw error

            int varLocal;
            //if (varLocal == 1) { }//Will throw error. Use of unassigned local variable.
            if (varClassLevel == 0)//This will not throw error
            {

            }

            //var sampleVar; Will throw error. Must be initialized.
        }
    }


    public class SampleClass1
    {

    }

    public class SampleClass2
    {

    }
}


