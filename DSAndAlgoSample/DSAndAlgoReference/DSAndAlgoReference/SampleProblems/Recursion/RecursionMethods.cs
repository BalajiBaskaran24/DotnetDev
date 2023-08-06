using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.SampleProblems.Recursion
{
    public class RecursionMethods
    {

        #region Stage 1 Single function

        public static void BasicPrint_Recursion(int n)
        {
            if (n <= 0)
                return;
            Console.WriteLine(n);
            BasicPrint_Recursion(n - 1);
        }

        #endregion

        #region Stage 2 functional and parameterised

        /// <summary>
        /// Functional recusrion
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Function_SumnNumbers_Functional(int n)
        {
            if (n == 0)
            {
                return n;
            }
            return n + Function_SumnNumbers_Functional(n - 1);
        }

        /// <summary>
        /// Parameterised recursion
        /// </summary>
        /// <param name="i"></param>
        /// <param name="sum"></param>
        public static void Function_SumnNumbers_Parameter(int i, int sum)
        {
            if (i == 0)
            {
                Console.WriteLine(sum);
                return;
            }
            Function_SumnNumbers_Parameter(i - 1, sum + i);
        }

        #region Swap array using recursion (return void) (n/2 for time and space complexity)

        public static int[] Input = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private static int n = 9;
        public static void ReverseArray(int left, int right)
        {
            if (left >= right) return;
            Swap(ref Input[left], ref Input[right]);
            ReverseArray(left + 1, right - 1);
        }
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

        #endregion

        #region Palindrome or not using recursion (functional recursive)

        static string Ip = "Madam";
        public static bool CheckPalindrome(int index)
        {
            if (index >= (Ip.Length / 2))
            {
                return true;
            }
            if (Ip[index] != Ip[Ip.Length - index - 1])
            {
                return false;
            }
            return CheckPalindrome(index + 1);
        }

        #endregion

        #endregion

        #region Stage 3 Multiple recursion calls

        /// <summary>
        /// Time and space Big0(2 power n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fibonacci_MultiRecursion(int n)
        {
            Console.WriteLine($"Called with {n}");
            if (n <= 1)
            {
                return n;
            }
            return Fibonacci_MultiRecursion(n - 1) + Fibonacci_MultiRecursion(n - 2);
        }

        /// <summary>
        /// Fibonacci using single recursion function
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static long Fibonacci_SingleRec(int n, long a = 0, long b = 1)
        {
            if (n == 0)
                return a;
            else
            {
                long temp = Fibonacci_SingleRec(n - 1, b, a + b);
                Console.WriteLine(temp);
                return temp;
            }
        }


        #endregion

        #region Stage 4 Subsequence

        static int[] SubInput = new int[4] { 3, 2, 10, 30 };

        /// <summary>
        /// Take / not take
        /// Time comp: 2 power n, space comp: O(n)
        /// </summary>
        /// <param name="index"></param>
        /// <param name="lst"></param>
        public static void PrintAllSubSeq(int index, List<int> lst)
        {
            if (index >= SubInput.Length)
            {
                Console.Write(lst.Aggregate("", (s, n) => $"{s} , {n}"));
                Console.WriteLine();
                return;
            }
            lst.Add(SubInput[index]);
            PrintAllSubSeq(index + 1, lst);
            lst.Remove(SubInput[index]);
            PrintAllSubSeq(index + 1, lst);
        }

        static int[] SumSubInput = new int[7] { 1, 3, 2, 5, 0, 1, 4 };
        static int ExpVal = 5;
        /// <summary>
        /// Take / not take
        /// Time comp: 2 power n, space comp: O(n)
        /// </summary>
        /// <param name="index"></param>
        /// <param name="lst"></param>
        public static bool PrintSumlSubSeq(int index, List<int> lst, int Sum)
        {
            if (index >= SumSubInput.Length)
            {
                if (Sum == ExpVal)
                {
                    foreach (int i in lst)
                        Console.Write(i + ", ");
                    Console.WriteLine();
                    return true;
                }
                return false;
            }
            lst.Add(SumSubInput[index]);
            Sum += SumSubInput[index];
            if (PrintSumlSubSeq(index + 1, lst, Sum))
            {
                return true;
            }

            Sum -= SumSubInput[index];
            lst.Remove(SumSubInput[index]);
            if (PrintSumlSubSeq(index + 1, lst, Sum))
            {
                return true;
            }
            Console.WriteLine("No match found");
            return false;
        }

        //TODO: Code to print count of subsequence that matches expected value

        #endregion


    }
}
