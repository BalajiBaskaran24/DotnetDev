using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.SampleProblems.Recursion
{
    public class RecursionMethods
    {



        public static void Function_SumnNumbers_Parameter(int i, int sum)
        {
            if (i == 0)
            {
                Console.WriteLine(sum);
                return;
            }
            Function_SumnNumbers_Parameter(i - 1, sum + i);
        }

        public static int Function_SumnNumbers_Functional(int n)
        {
            if (n == 0)
            {
                return n;
            }
            return n + Function_SumnNumbers_Functional(n - 1);
        }

    }
}
