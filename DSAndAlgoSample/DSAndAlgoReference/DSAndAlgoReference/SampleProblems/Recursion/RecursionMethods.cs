using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.SampleProblems.Recursion
{
    public class RecursionMethods
    {
        public static int[] Input = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static void ReverseArray(int left, int right)
        {
            if (left >= right) return;
            Swap(ref Input[left], ref Input[right]);
            ReverseArray(left + 1, right - 1);
        }
        private static int n = 9;
        public static void ReverseArrayOneParam(int index)
        {
            if (index >= (n / 2))
                return;
            Swap(ref Input[index], ref Input[n - index - 1]);
            index += 1;
        }


        private static void Swap(ref int a, ref int b)
        {
            int Temp = a;
            a = b;
            b = Temp;
        }


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
