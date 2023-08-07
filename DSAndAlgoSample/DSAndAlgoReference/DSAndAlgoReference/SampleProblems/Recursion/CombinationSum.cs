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
    }
}
