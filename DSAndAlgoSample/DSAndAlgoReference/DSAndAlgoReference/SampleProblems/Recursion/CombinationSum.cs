using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.SampleProblems.Recursion
{
    public class CombinationSum
    {
        public IList<IList<int>> Starter(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            if (candidates == null || candidates.Length == 0) return result;

            Array.Sort(candidates); // Optional, for optimization
            FindCombinations(candidates, target, 0, new List<int>(), result);

            return result;
        }

        /// <summary>
        /// With for loop
        /// </summary>
        /// <param name="candidates"></param>
        /// <param name="remaining"></param>
        /// <param name="start"></param>
        /// <param name="current"></param>
        /// <param name="result"></param>
        private void FindCombinations(int[] candidates, int remaining, int start, List<int> current, IList<IList<int>> result)
        {
            if (remaining < 0) return;
            if (remaining == 0)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                if (candidates[i] > remaining) break; // Optimization step since we have sorted the array

                current.Add(candidates[i]);
                FindCombinations(candidates, remaining - candidates[i], i, current, result); // Note that 'i' is passed, not 'i+1' as we can reuse the same number
                current.RemoveAt(current.Count - 1); // Backtrack
            }
        }

        /// <summary>
        /// Only with recursion
        /// </summary>
        /// <param name="candidates"></param>
        /// <param name="remaining"></param>
        /// <param name="index"></param>
        /// <param name="current"></param>
        /// <param name="result"></param>
        public static void FindCombinations_OnlyRecursion(int[] candidates, int remaining, int index, List<int> current, IList<IList<int>> result)
        {
            if (remaining == 0)
            {
                result.Add(new List<int>(current));
                return;
            }
            if (remaining < 0 || index >= candidates.Length) return;
            // Skip the candidate at current index
            FindCombinations_OnlyRecursion(candidates, remaining, index + 1, current, result);
            // Choose the candidate at current index
            current.Add(candidates[index]);
            FindCombinations_OnlyRecursion(candidates, remaining - candidates[index], index, current, result); // same index because the number can be reused
            current.RemoveAt(current.Count - 1); // Backtrack
        }
    }
}
