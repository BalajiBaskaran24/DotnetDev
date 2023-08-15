using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference
{
    public class FindAllSubset
    {
        //There are 2^n subsets for any given set with n elements

        //1. Recursion method


        /// <summary>
        /// Binary-counter-like approach
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static List<List<int>> GetAllSubsets(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();
            int n = nums.Length;

            // There are 2^n subsets for any given set with n elements
            for (int i = 0; i < (1 << n); i++)
            {
                List<int> subset = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    // If the j-th bit in the binary representation of i is set,
                    // add the j-th element of nums to the current subset
                    if ((i & (1 << j)) != 0)
                    {
                        subset.Add(nums[j]);
                    }
                }

                result.Add(subset);
            }

            return result;
        }

        public static void Starter()
        {
            int[] array = { 1, 2, 3 };
            List<List<int>> subsets = GetAllSubsets(array);

            // Print the result
            foreach (var subset in subsets)
            {
                Console.WriteLine(string.Join(", ", subset));
            }
        }

    }
}
