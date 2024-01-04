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
        /// DP problem
        /// Since max profit and min value is tracked every time
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int GetMaxProfit(int[] input)
        {
            int MinimumVal = input[0];
            int MaxProfit = 0;
            for (int i = 1; i < input.Length; i++)
            {
                int CurrentProfit = input[i] - MinimumVal;
                MaxProfit = Math.Max(CurrentProfit, MaxProfit);
                MinimumVal = Math.Min(MinimumVal, input[i]);
            }
            return MaxProfit;
        }
    }
}
