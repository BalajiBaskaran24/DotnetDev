using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.SampleProblems
{
    public class FAProblems
    {
        //Palindrome
        //Anagram
        //Fibonacci


       

        /// <summary>
        /// Big O(n) With Memoization (Top-Down DP)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="memo"></param>
        /// <returns></returns>
        public static int Fibonacci_Mem(int n, Dictionary<int, int> memo = null)
        {
            Console.WriteLine($"Called with {n}");
            if (memo == null)
            {
                memo = new Dictionary<int, int> { { 0, 0 }, { 1, 1 } };
            }
            if (!memo.ContainsKey(n))
            {
                memo[n] = Fibonacci_Mem(n - 1, memo) + Fibonacci_Mem(n - 2, memo);
            }
            return memo[n];
        }


        /// <summary>
        /// With Tabulation (Bottom-Up DP)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fibonacci_WithTab(int n)
        {
            int[] fib = new int[n + 1];
            fib[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            return fib[n];
        }



    }
}
