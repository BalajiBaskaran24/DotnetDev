using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.SampleProblems.DynamicProgramming
{
    internal class Buysellstock
    {
        /// <summary>
        /// Problem statement: Buy and sell should happen once. Identify the maximum profit
        /// DP problem
        /// Since max profit and min value is tracked every time
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int GetMaxProfitOneTransaction(int[] input)
        {
            int MinimumVal = input[0];
            int MaxProfit = 0;
            for (int i = 1; i < input.Length; i++)
            {
                int CurrentProfit = input[i] - MinimumVal;
                MaxProfit = Math.Max(CurrentProfit, MaxProfit);
                MinimumVal = Math.Min(MinimumVal, input[i]);
            }
            Console.WriteLine($"One transaction Max profit: {MaxProfit}");
            return MaxProfit;
        }

        /// <summary>
        /// Buy and sell can happen multiple times. Atmost we can 
        /// hold only one stock
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int GetMaxProfitMultipleTransaction(int[] input)
        {
            int MaxProfit = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > input[i - 1])
                {
                    MaxProfit += input[i] - input[i - 1];
                }
            }
            Console.WriteLine($"Multiple transaction Max profit: {MaxProfit}");
            return MaxProfit;
        }
    }
}
