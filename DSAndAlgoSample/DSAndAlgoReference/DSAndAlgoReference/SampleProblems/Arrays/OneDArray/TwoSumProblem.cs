using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.SampleProblems.Arrays.OneDArray
{
    internal class TwoSumProblem
    {

        /// <summary>
        /// Expected to return the indexes which sums to provide target
        /// </summary>
        /// <param name="input"></param>
        public static void BetterSolutionWithIndex(int target, int[] input)
        {
            //Use a dictionary. Store number as key and index as value
            Dictionary<int, int> Data = new Dictionary<int, int>();
            for (int i = 0; i < input.Length; i++)
            {
                int ReqValue = target - input[i];
                if (Data.ContainsKey(ReqValue))
                {
                    Console.WriteLine($"First: {input[i]} at index {i} and second: {ReqValue} at index {Data[ReqValue]}");
                    return;
                }
                else
                {
                    Data[input[i]] = i;
                }
            }
            Console.WriteLine("Elements for given target value is not found");
            return;
        }

        public static void OptimalSolutionWoIndex(int target, int[] input)
        {
            //Sort the array
            //Use two pointer(P) approach
            //If P1 + P2 is greater than target value, do right pointer index -1
            //else if, equal to target, return "YES"
            //else, left pointer +1

            Array.Sort(input, 0, input.Length);
            int LeftPointer = 0, RightPointer = input.Length - 1;

            while (LeftPointer < RightPointer)
            {
                int Sum = input[LeftPointer] + input[RightPointer];
                if (Sum == target)
                {
                    Console.WriteLine("Target value found");
                    return;
                }
                else if (Sum < target)
                {
                    LeftPointer++;
                }
                else
                {
                    RightPointer++;
                }
            }
            Console.WriteLine("Target value not found");
        }
    }
}
