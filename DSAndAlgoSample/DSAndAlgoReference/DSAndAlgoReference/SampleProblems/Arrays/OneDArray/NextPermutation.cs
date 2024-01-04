using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.SampleProblems.Arrays.OneDArray
{
    public class NextPermutation
    {
        /// <summary>
        /// Input: Find the next permutation of: 2,1,3
        /// Output: 2,3,1
        /// 
        /// Input: 3,2,1
        /// Output: 1,2,3
        /// 
        /// All possible permutations
        /// 1,2,3
        /// 1,3,2
        /// 2,1,3
        /// 2,3,1
        /// 3,1,2
        /// 3,2,1
        /// 
        ///Input:: 2,1,5,4,3,0,0
        ///Output:: 2,3,0,0,1,4,5 
        /// 
        /// 
        /// 
        /// 
        /// </summary>
        public static void GetNextPermutation(int[] input)
        {
            int n = input.Length; // size of the array.

            // Step 1: Find the break point:
            int ind = -1; // break point
            for (int i = n - 2; i >= 0; i--)
            {
                if (input[i] < input[i + 1])
                {
                    // index i is the break point
                    ind = i;
                    break;
                }
            }

            // If break point does not exist:
            if (ind == -1)
            {
                // reverse the whole array:
                Array.Reverse(input, 0, input.Length);
                return;
            }

            // Step 2: Find the next greater element and swap it with arr[ind]:
            for (int i = n - 1; i > ind; i--)
            {
                if (input[i] > input[ind])
                {
                    int temp = input[i];
                    input[i] = input[ind];
                    input[ind] = temp;
                    break;
                }
            }

            //Step 3: reverse the right half:
            Array.Reverse(input, ind + 1, input.Length - (ind + 1));
            Console.WriteLine(string.Join(" ", input.Select(x => x.ToString())));
            return;
        }
    }
}
