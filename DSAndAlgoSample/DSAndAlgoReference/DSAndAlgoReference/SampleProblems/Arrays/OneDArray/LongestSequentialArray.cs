using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.SampleProblems.Arrays.OneDArray
{
    public class LongestSequentialArray
    {
        /// <summary>
        /// Numbers can be in any order
        /// Output: Count of longest consecutive sequence
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int LongestConsecutiveBetter(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int Longest = 1;
            int Count = 0;
            int LastSmaller = int.MinValue;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] - 1 == LastSmaller)
                {
                    Count++;
                    LastSmaller = nums[i];
                }
                else if (nums[i] != LastSmaller)
                {
                    Count = 1;
                    LastSmaller = nums[i];
                }
                Longest = Math.Max(Longest, Count);
            }

            return Longest;
        }
    }
}
